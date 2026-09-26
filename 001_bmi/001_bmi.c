#include<stdio.h>

int main() {
	float h, w, bmi;//키, 몸무게, bmi 받기

	printf("키(cm) : ");
	scanf("%f", &h);//키 입력받기
	printf("몸무게(kg) : ");
	scanf("%f", &w);//몸무게 입력받기
	
	h /= 100; //키를 m로 변환하기
	bmi = w / (h * h);//bmi 계산하기

	printf("%f\n", bmi);
}