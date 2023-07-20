## WPF 중첩된 사용자정의 컨트롤에서 내부 컨트롤 속성에 바인딩하려면?   
[참고사이트] https://www.youtube.com/watch?v=OaCZxfMDnfM   

- [ ] 확인 사항

```csharp
<UserControl x:Class="WPFTutorial.Controls.SubControl1"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:local="clr-namespace:WPFTutorial.Controls"
             mc:Ignorable="d" 
             x:Name="root"
             d:DesignHeight="450" d:DesignWidth="800">
    <UserControl.Resources>
        <Style TargetType="{x:Type TextBox}">
            <Setter Property="Margin" Value="10"/>
        </Style>
    </UserControl.Resources>
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition/>
            <RowDefinition/>
        </Grid.RowDefinitions>

        <TextBox Text="{Binding Text1, ElementName=root}" Grid.Row="0"/>
        <TextBox Text="{Binding Text2, ElementName=root}" Grid.Row="1"/>
    </Grid>
</UserControl>
```
여기서 _**x:Name="root"**_ 의 의미와 _**ElementName=root**_ 의 의미에 대해 확인 하고 싶다.   
