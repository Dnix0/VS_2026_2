# VS 2026-2 Class Projects

Visual Studio 수업에서 작성한 **C, C#, Windows Forms, WPF 실습 코드**를 정리한 저장소입니다.

기초 문법부터 GUI 애플리케이션, 차트, 사용자 정의 컨트롤, 이벤트 처리, Firebase CRUD 실습까지 수업 진행 순서에 따라 프로젝트를 보관하고 있습니다.

## Development Environment

- Visual Studio
- C
- C#
- .NET Framework 4.7.2
- Windows Forms
- Windows Presentation Foundation (WPF)

> 프로젝트별 생성 시점과 설정에 따라 사용 중인 .NET Framework 버전이 다를 수 있습니다.

## Main Topics

이 저장소에는 다음과 같은 수업 및 실습 내용이 포함되어 있습니다.

- C 및 C# 기본 문법
- BMI 계산 프로그램
- 문자열 형식 지정
- Label, MessageBox, CheckBox, RadioButton 등의 Windows Forms 컨트롤
- 성적 및 계산기 프로그램
- Chart와 그래프
- 클래스, 객체, 상속 및 도형 예제
- Windows Forms 애플리케이션
- WPF 기본 구조와 XAML
- Grid, StackPanel, UniformGrid 등의 WPF 레이아웃
- UserControl과 이벤트 처리
- 로그인 화면
- 디지털 시계와 회전 시계
- 체스판 및 카드 매칭 게임
- Firebase Realtime Database CRUD 실습

## Repository Structure

프로젝트 폴더는 수업 및 실습 진행 순서에 따라 번호를 붙여 관리합니다.

```text
VS_2026_2/
├── 001_bmi/
├── 002_bmiForm/
├── 003_Format/
├── ...
├── 039_WPF_clac/
├── WPF_Rotation_clock/
├── 041_Maching_Game/
├── VS_2026_2.sln
└── README.md
```

일부 폴더명에는 수업 당시 사용한 이름이나 오탈자가 그대로 남아 있을 수 있습니다.

## How to Run

1. 저장소를 Clone하거나 ZIP 파일로 내려받습니다.
2. Visual Studio에서 `VS_2026_2.sln` 파일을 엽니다.
3. 실행할 프로젝트를 마우스 오른쪽 버튼으로 클릭합니다.
4. **시작 프로젝트로 설정**을 선택합니다.
5. 필요한 NuGet 패키지를 복원합니다.
6. 프로젝트를 빌드하고 실행합니다.

저장소를 Clone하려면 다음 명령을 사용할 수 있습니다.

```bash
git clone https://github.com/Dnix0/VS_2026_2.git
```

## Firebase Example

Firebase 관련 프로젝트는 수업 중 Realtime Database의 CRUD 기능을 연습하기 위해 작성했습니다.

보안을 위해 다음 실제 설정값은 저장소에서 제거했습니다.

- Firebase Database Secret
- Firebase Realtime Database URL
- 개인 Firebase 프로젝트 정보

Firebase 예제를 실행하려면 코드의 placeholder를 본인의 Firebase 설정으로 교체해야 합니다.

```csharp
IFirebaseConfig config = new FirebaseConfig
{
    AuthSecret = "YOUR_FIREBASE_DATABASE_SECRET",
    BasePath = "YOUR_FIREBASE_DATABASE_URL"
};
```

실제 인증정보, API 키, 서비스 계정 JSON 파일 등은 GitHub에 커밋하지 마세요.

## Excluded Files

다음과 같은 자동 생성 파일 및 빌드 결과물은 `.gitignore`를 통해 저장소에서 제외합니다.

- `.vs/`
- `bin/`
- `obj/`
- `Debug/`
- `Release/`
- `x64/`, `x86/`
- `packages/`
- `*.user`, `*.suo`, `*.pdb`, `*.log`

필요한 NuGet 패키지는 Visual Studio에서 다시 복원할 수 있습니다.

## Notes

- 이 저장소는 수업 실습과 개인 복습을 위한 코드 모음입니다.
- 일부 프로젝트는 개념 학습 중 작성한 간단한 예제이며, 완성된 배포용 애플리케이션이 아닙니다.
- 프로젝트에 따라 실행 환경, 참조 라이브러리 또는 NuGet 패키지 복원이 필요할 수 있습니다.
- 소스 코드에는 수업 당시의 주석과 구현 방식이 포함되어 있습니다.

## Purpose

This repository is intended for educational purposes and personal study.
