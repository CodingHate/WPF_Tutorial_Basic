

### DtatTemplate 확인
<https://github.com/jamesnet214/wpf-study#readme>

## 3. DataTemplate

- ContentControl을 상속 받는 클래스의 ContentTemplate을 재정의 해줌
  - `Content`를 재정의하고 있으며, `ContentControl`을 상속 받는 `Window`나 `Button`이나 모두 같은 원리로 동작한다.(ContentControl을 상속 받는 모든 개체)
  - `Button`, `ToggleButton`, `CheckBox`, `RadioButton` 등에 모두 같은 `DataTemplate`이 적용된 것을 볼 수 있다.


- 실행 화면 (좌측부터 `Button`, `ToggleButton`, `CheckBox`, `RadioButton` - 같은 `DataTemplate`을 사용하고 있다.)

![DataTemplate Test](https://user-images.githubusercontent.com/72642836/235357755-1ed92831-42a2-4092-918c-9540b061420e.png)

