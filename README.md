# WPF_Tutorial

youtube: https://www.youtube.com/watch?v=ZsO29yvxpSM&t=620s </br>
dependency property 연습</br>

usercontrol 사용하여 구성 </br>
propdb를 사용하여 dependency 문장을 자동 생성 </br>
usercontrol의 Name "root"를 지정하여 parameter 획득 </br>

# 예시 1
public static readonly DependencyProperty Value1Property = </br>
            DependencyProperty.Register("Value1", typeof(decimal), typeof(CalculateControl), new PropertyMetadata(0m, OnValueChanged, CoerceLimitValue));</br>
new PropertyMetadata(0m, OnValueChanged, CoerceLimitValue));</br>
0m : 초기 값 </br>
onValueChanged: 변경되었을 경우 수행 되는 함수 </br>
CoerceLimitValue : 제한 되는 함수 </br>

# 예시 2
 <local:CalculateControl Value1="{Binding Value11}" Value2="{Binding Value2}" Operator="{Binding Operator}" DesignMode="WHITE"/> </br>
 Value1: Usercontrol에서 만든 변수 </br>
 Value11: mvvm에서 만든 MainViewModel 변수 </br>
