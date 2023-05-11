# WPF_Tutorial

youtube: https://www.youtube.com/watch?v=ZsO29yvxpSM&t=620s </br>
dependency property 연습</br>

usercontrol 사용하여 구성 </br>
propdb를 사용하여 dependency 문장을 자동 생성 </br>
usercontrol의 Name "root"를 지정하여 parameter 획득 </br>

public static readonly DependencyProperty Value1Property = </br>
            DependencyProperty.Register("Value1", typeof(decimal), typeof(CalculateControl), new PropertyMetadata(0m, OnValueChanged, CoerceLimitValue));</br>
new PropertyMetadata(0m, OnValueChanged, CoerceLimitValue));</br>
0m : 초기 값 </br>
onValueChanged: 변경되었을 경우 수행 되는 함수 </br>
CoerceLimitValue : 제한 되는 함수 </br>
