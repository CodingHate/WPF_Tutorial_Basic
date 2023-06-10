# dependency property

youtube: https://www.youtube.com/watch?v=ZsO29yvxpSM&t=620s </br>
dependency property 연습</br>


**Data Binding** UI 요소의 속성 값을 다른 UI 요소나 데이터 소스와 바인딩 할 수 있습니다.   
스타일과 템플릿 스타일과 템플릿을 사용하여 UI 요소의 모양과 동작을 쉽게 변경 할 수 있습니다.   
상속: 상위 요소에서 정의된 속성 값을 하위 요소에서 사용 할 수 있습니다.   


usercontrol 사용하여 구성 </br>
propdb를 사용하여 dependency 문장을 자동 생성 </br>
usercontrol의 Name "root"를 지정하여 parameter 획득 </br>

## 예시 1
```c#
public static readonly DependencyProperty Value1Property = </br>
            DependencyProperty.Register("Value1", typeof(decimal), typeof(CalculateControl), new PropertyMetadata(0m, OnValueChanged, CoerceLimitValue));
```
new PropertyMetadata(0m, OnValueChanged, CoerceLimitValue));</br>
0m : 초기 값 </br>
onValueChanged: 변경되었을 경우 수행 되는 함수 </br>
CoerceLimitValue : 제한 되는 함수 </br>

## 예시 2
```c#
 <local:CalculateControl Value1="{Binding Value11}" Value2="{Binding Value2}" Operator="{Binding Operator}" DesignMode="WHITE"/> </br>
```
Value1: Usercontrol에서 만든 변수 </br>
Value11: mvvm에서 만든 MainViewModel 변수 </br>
