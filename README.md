# 🍦아이스크림 볼 캐치

![game](https://user-images.githubusercontent.com/77602511/105016073-8eed5200-5a85-11eb-8e37-f3162b23bf06.png)

## 게임 개요
3D 평면으로 떨어지는 아이스크림 볼을 제시된 이미지에 따라 콘에 받는 게임입니다.

총 3단계로 이루어져 있습니다.

## 조작법
화살표를 이용해 아이스크림콘을 이동합니다.

LEVEL이 올라갈수록 아이스크림의 낙하 속도가 증가합니다.

## 시연 영상
[Youtube url](https://youtu.be/0vylodXlG1g)

## 게임 설명
1. 우측 상단에 사용자가 만들어야 할 아이스크림 이미지가 랜덤으로 제시됩니다.

2. 아이스크림콘을 이동하며 아이스크림을 받습니다.

3. 아이스크림이 세 개 이상 쌓이면 C 버튼을 눌러서 주어진 이미지와의 일치 여부를 확인하고 새로운 랜덤 이미지를 제시합니다.
+ 일치하면 **CORRECT**가 1만큼 증가합니다.
+ 일치하지 않으면 **CORRECT**는 변하지 않습니다.

4. **CORRECT**가 2만큼 증가할 때마다 **LEVEL**이 1만큼 증가합니다.

5. 아이스크림이 아닌 몬스터를 받으면 **LIFE**가 1만큼 감소합니다.

6. **LEVEL3**을 완료하면 게임을 성공해 종료합니다.

7. **LIFE**가 0이 되면 게임에 실패해 종료합니다.

8. T 버튼을 누르면 게임이 일시정지합니다.

9. 플레이 도중 D 버튼을 누르면 아이스크림이 리셋됩니다.

## 개발 환경
+ Unity3D
+ Visual Studio 2019

## 사용한 외부 에셋
1. _RPGMonsterPartnersPBRPolyart - BeholderPBR prefab_

게임 내에서 몬스터 오브젝트로 사용했습니다.

![image](https://user-images.githubusercontent.com/77602511/105014506-decb1980-5a83-11eb-8bd4-c2dceaba61d1.png)
---
2. _ConeCollider - ConeCollider_

색상 material을 입혀서 아이스크림콘으로 사용했습니다.

![image](https://user-images.githubusercontent.com/77602511/105014646-05895000-5a84-11eb-9e5f-2a0eaa6a4ca0.png)
---
3. _Christmas Tree - POLYCRAFT Series - 선물상자, 트리, 보석 등_

게임 맵을 꾸미기 위해 사용했습니다.

![image](https://user-images.githubusercontent.com/77602511/105014688-120da880-5a84-11eb-8251-e1d16ed1d474.png)
![image](https://user-images.githubusercontent.com/77602511/105014702-15a12f80-5a84-11eb-956a-173550e8c4cf.png)
---
4. _Snowed Fence - fence_double_

게임 맵을 꾸미기 위해 사용했습니다.

![image](https://user-images.githubusercontent.com/77602511/105014728-1cc83d80-5a84-11eb-8009-d9d478e061bb.png)
---


## 발전 방향
1. 더 많은 낙하물(아이스크림 또는 장애물)과 그에 대한 게임 규칙을 추가할 예정입니다.
2. 아이스크림이 쌓일 때 나타나는 이펙트를 추가할 예정입니다.

## 프로젝트 참여 인원
1명
