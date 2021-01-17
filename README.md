# Unity_Custom_Attributes

- 네임스페이스  : Rito.CustomAttributes


------
# [1] MemoBox
- 프로퍼티의 상단에 상자 및 메모를 표시합니다.

|매개변수|설명|
|---|---|
|Contents|메모에 적을 내용을 기록합니다. 스트링을 콤마로 구분할 경우 각각 개행됩니다.|
|FontSize|글자 크기 (기본 : 12)|
|LineSpacing|줄 간격 (기본 : 2)|
|TextColor|글자 색상 (기본 : White)|
|BoxColor|상자 색상 (기본 : Black)|
|MarginTop|상자 위쪽 여백 (기본 : 5)|
|MarginBottom|상자 아래쪽 여백 (기본 : 5)|
|PaddingTop|글자 위쪽 여백 (기본 : 5)|
|PaddingBottom|글자 아래쪽 여백 (기본 : 5)|
|PaddingLeft|글자 왼쪽 여백 (기본 : 5)|
|BoldText|굵은 글씨 적용 (기본 : false)|

<img src="https://user-images.githubusercontent.com/42164422/104818128-f7abb300-5868-11eb-873b-2dd9d333254f.PNG" width="500">


# [2] MethodButton
- 클릭할 경우 메소드를 호출하는 버튼을 표시합니다.
- 해당 클래스 내에 존재하는 메소드만 호출할 수 있습니다.

|매개변수|설명|
|---|---|
|MethodName|버튼을 누르면 호출할 메소드 이름|
|Text|버튼 내에 표시할 텍스트|
|ButtonColor|버튼 색상 (기본 : 유니티 기본 버튼 색상(회색))|
|TextColor|글자 색상 (기본 : 흰색)|
|TextSize|글자 크기 (기본 : 12)|
|WidthRatio|버튼 가로 너비의 비율(0.0f ~ 1.0f, 기본 : 1.0f)|
|Height|버튼 높이 (기본 : 18)|
|PropertyPlacement|프로퍼티 표시 방법 (Hidden : 숨기기, Top : 버튼의 상단, Bottom : 버튼의 하단, 기본 : Hidden)|
|HorizontalAlignment|버튼의 가로 정렬 방법 (Left : 좌측 정렬, Center : 중앙 정렬, Right : 우측 정렬, 기본 : Center)|

<img src="https://user-images.githubusercontent.com/42164422/104818130-f9757680-5868-11eb-86f6-2fd523769330.png" width="500">


# [3] AutoInject
- 컴포넌트 타입에 사용할 수 있습니다.
- 필드의 타입을 자동으로 인식하여, 컴포넌트를 찾아 초기화시켜주는 기능을 수행합니다.
- 성공한 경우 녹색 메시지박스, 실패한 경우 노란색 메시지박스, 타입이 일치하지 않는 경우 붉은색 메시지박스를 표시합니다.

|EInjection|설명|
|---|---|
|GetComponent|자신의 게임오브젝트에서 해당 컴포넌트를 찾습니다.|
|GetComponentInChildren|자신 또는 자식 게임오브젝트들에서 해당 컴포넌트를 찾습니다.|
|GetComponentInChildrenOnly|자신을 제외한 자식 게임오브젝트들에서 해당 컴포넌트를 찾습니다.|
|GetComponentInAllChildren|비활성화된 게임오브젝트를 포함하여, 자신 또는 자식 게임오브젝트들에서 해당 컴포넌트를 찾습니다.|
|GetComponentInParent|자신 또는 부모 게임오브젝트들에서 해당 컴포넌트를 찾습니다.|
|GetComponentInParentOnly|자신을 제외한 부모 게임오브젝트들에서 해당 컴포넌트를 찾습니다.|
|FindObjectOfType|씬에서 해당 컴포넌트를 찾습니다.|

|EModeOption|설명|
|---|---|
|Always|대상이 초기화되지 않은 상태라면 항상 동작합니다.|
|EditModeOnly|에디터 모드에서만 동작합니다.|
|PlayModeOnly|플레이모드에서만 동작합니다.|

<img src="https://user-images.githubusercontent.com/42164422/104818131-fa0e0d00-5868-11eb-829d-710fcc6f87b6.png" width="500">

<img src="https://user-images.githubusercontent.com/42164422/104818397-b4eada80-586a-11eb-903f-3f04994498fc.png" width="500">


# [4] Required
- 컴포넌트 타입에 사용할 수 있습니다.
- 해당 필드가 null인 경우, 경고를 표시합니다.

|매개변수|설명|
|---|---|
|ShowMessageBox|해당 필드가 null인 경우, 상단부에 경고 메시지 박스를 표시합니다. (기본 : true)|
|ShowLogError|해당 필드가 null인 경우, 디버그 로그 에러를 통해 경고합니다. (기본 : false)|

<img src="https://user-images.githubusercontent.com/42164422/104821345-6a735900-587e-11eb-8b09-cd0877db763e.png" width="500">


# [5] LayerDropdown, TagDropdown
- 각각 레이어 및 태그를 선택할 수 있는 드롭다운 메뉴를 표시합니다.
- LayerDropdown 애트리뷰트는 string, int타입의 필드에 사용할 수 있습니다.
- TagDropdown 애트리뷰트는 string 타입의 필드에 사용할 수 있습니다.
<img src="https://user-images.githubusercontent.com/42164422/104818134-fc706700-5868-11eb-96df-2a80d909492c.png" width="500">


# [6] Readonly
- 인스펙터에 해당 필드를 수정할 수 없도록 비활성화된 채로 표시합니다.
- 비활성화되는 타이밍을 지정할수있습니다.

|ReadOnlyOption|설명|
|---|---|
|Always|항상 비활성화합니다.|
|EditMode|에디터 모드에서만 비활성화합니다.|
|PlayMode|플레이 모드에서만 비활성화합니다.|
<img src="https://user-images.githubusercontent.com/42164422/104818135-fd08fd80-5868-11eb-8692-57d61416fba5.png" width="500">


# [7] ProgressBar
- 현재 필드의 값 및 지정 최댓값을 가로 막대 형태로 표시합니다.
- int, float, double 타입의 필드에 동작합니다.

|매개변수|설명|
|---|---|
|MaxValue|최댓값|
|BarColor|막대 색상 (기본 : Gray)|
|TextColor|글자 색상 (기본 : White)|
|ClampInRange|필드의 값이 최댓값을 넘어가지 못하게 제한 (기본 : false)|

<img src="https://user-images.githubusercontent.com/42164422/104818137-fe3a2a80-5868-11eb-9921-e2d2f5d8c22b.png" width="500">


# [8] Label
- 프로퍼티의 텍스트 및 색상을 지정합니다.
- 배열 및 클래스 형태의 필드에는 적용되지 않습니다.

|매개변수|설명|
|---|---|
|Text|표시할 텍스트|
|TextColor|글자 색상(기본 : White)|
<img src="https://user-images.githubusercontent.com/42164422/104818138-ff6b5780-5868-11eb-8cbb-2cb456aa52ba.png" width="500">


# [9] SpaceTop
- 프로퍼티의 상단 여백을 지정합니다. (기본 : 9)
<img src="https://user-images.githubusercontent.com/42164422/104818139-01351b00-5869-11eb-8ceb-e72dc88cf83a.png" width="500">


# [10] SpaceBottom
- 프로퍼티의 하단 여백을 지정합니다. (기본 : 9)
<img src="https://user-images.githubusercontent.com/42164422/104818141-02fede80-5869-11eb-85ff-2c1b572f1ad8.png" width="500">
