# dependency property

youtube: https://www.youtube.com/watch?v=ZsO29yvxpSM&t=620s </br>
dependency property 연습</br>


**Data Binding** UI 요소의 속성 값을 다른 UI 요소나 데이터 소스와 바인딩 할 수 있습니다.   
스타일과 템플릿 스타일과 템플릿을 사용하여 UI 요소의 모양과 동작을 쉽게 변경 할 수 있습니다.   
상속: 상위 요소에서 정의된 속성 값을 하위 요소에서 사용 할 수 있습니다.   
 

usercontrol 사용하여 구성 </br>
propdb를 사용하여 dependency 문장을 자동 생성 </br>
usercontrol의 Name "root"를 지정하여 parameter 획득 </br>

## study 01
```c#
public static readonly DependencyProperty Value1Property = </br>
            DependencyProperty.Register("Value1", typeof(decimal), typeof(CalculateControl), new PropertyMetadata(0m, OnValueChanged, CoerceLimitValue));
```
new PropertyMetadata(0m, OnValueChanged, CoerceLimitValue));   
0m : 초기 값   
onValueChanged: 변경되었을 경우 수행 되는 함수   
CoerceLimitValue : 제한 되는 함수   

```csharp
        public static readonly DependencyProperty DesignModeProperty =
            DependencyProperty.Register("DesignMode", typeof(DesignMode), typeof(CalculateControl), new PropertyMetadata(DesignMode.WHITE, OnDesignModeChanged));
```
현재 Desiginmode의 초기 값이 현재 WHITE로 설정 되어 있다.   
***만약*** **MainWindow.xaml** 의 초기 값을 WHITE로 설정을 하면 **OnDesignModeChanged** 이 실행이 안된다.   
DependencyProperty는 값이 다를 때 이벤트 핸들러가 수행 하게 된다.   


## study 02
```c#
 <local:CalculateControl Value1="{Binding Value11}" Value2="{Binding Value2}" Operator="{Binding Operator}" DesignMode="WHITE"/> </br>
```
Value1: Usercontrol에서 만든 변수 </br>
Value11: mvvm에서 만든 MainViewModel 변수 </br>

## study 03
**MainWindow.xaml.cs** 에서 DataContext 연결   
```c#
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
```
**MainWindow.xaml** 에서 Binding으르 통하여 **MainViewModel** 의 파라미터 연결
**MainWindow.xaml**
```csharp
    <Grid>
        <local:CalculateControl Value1="{Binding Value1}" Value2="{Binding Value2}" Operator="{Binding Operator}" DesignMode="WHITE"/>
    </Grid>
```
**MainViewModel.cs**
```csharp
        public decimal Value1
        {
            get => _value1;
            set => SetProperty(ref _value1, value);
        }

        public decimal Value2
        {
            get => _value2;
            set => SetProperty(ref _value2, value);
        }

        public string Operator
        {
            get => _operator;
            set => SetProperty(ref _operator, value);
        }
```
연결 하고, 자동으로 **CalculateControl.xaml.cs** 의존성 프로퍼티에 의하여 계산이 되어 출력이 된다.

## study 04   


## 이해 필요 부분
### 1. Name="root"
```c#
<UserControl x:Class="WPFTutorial.CalculateControl"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:local="clr-namespace:WPFTutorial"
             mc:Ignorable="d" 
             Name="root"
             d:DesignHeight="450" d:DesignWidth="800" 
             Background="{Binding ElementName=root, Path=UserControlBackground}"
             d:Background="White">
```
**CalculateControl.xaml** 에서 **Name="root"** 는 CalculateControl 컨트롤의 이름을 "root"로 지정.
Name 속성은 XAML에서 개체에 고유한 이름을 부여하여 사용.
이름은 해당 컨트롤을 식별하고 다른 요소와 상호작용하는 데 사용될 수 있습니다.   

예를 들어 코드 뒷단에서 해당 컨트롤에 접근하거나 데이터 바인딩을 설정할 때 해당 이름을 사용할 수 있습니다.   
여기서 "root"는 컨트롤의 이름으로 선택된 것이며, 다른 이름을 선택할 수도 있습니다.   
일반적으로 "root"는 최상위 컨트롤이나 주 컨테이너 요소에 할당되는 이름으로 자주 사용됩니다.  
하지만 실제로는 원하는 이름을 사용할 수 있습니다.


### 2. Binding
**CalculateControl.xaml** 에서 
```c#
<Setter Property="Foreground" Value="{Binding ElementName=root, Path= TextBoxForeground}" />
```
의 의미는 다음과 같다.   
**ElementName** 에서 **CalculatorControl.xaml** 의 지정을 하였고 그 안에 TextBoxForground를 연결하여 binding을 한 것이다.   
**CalculateControl.xaml.cs** 안에 binding이 되어 있는 것을 확인 할 수 있다.  
