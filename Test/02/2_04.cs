using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 선택정렬
 * - 알고리즘에서 배열의 원소를 2,3,4,5번째 원소와 차례로 비교
 * - 정렬 알고리즘에는 선택정렬, 삽입정렬, 퀵정렬, 버블정렬 등이 있다. (유튜브 참조)
 * 
 * 정렬방법
 * 1단계 : 배열의 첫번째 원소를 2,3,4,5번째 원소와 차례로 비교
 * 2단계 : 첫번째 원소보다 작은 원소를 찾으면 ㅓ로 자리 교환
 * 3단계 : 배열의 두번째 원소를 3,4,5번째 원소와 차례로 비교
 * 4단계 : 두번째 원소보다 작은 원소를 찾으면 서로 자리 교환
 * 5단계 : 위와 
 * 
 * 
 * 아래) 선생님
 * 선택정렬
 *  - 알고리즘에서 배열의 원소를 정렬하는 가장 기본적인 방법
 *  - 정렬 알고리즘에는 선택정렬, 삽입정렬, 퀵정렬, 버블정렬 등이 있다.
 * 
 * 정렬방법
 *  1단계 : 배열의 첫번째 원소를 2, 3, 4, 5번째 원소와 차례로 비교
 *  2단계 : 첫번째 원소보다 작은 원소를 찾으면 서로 자리 교환
 *  3단계 : 배열의 두번째 원소를 3, 4, 5번째 원소와 차례로 비교
 *  4단계 : 두번째 원소보다 작은 원소를 찾으면 서로 자리 교환
 *  5단계 : 위와 같이 최종 숫자가 하나 남을 때까지 반복 수행
 */

//선택정렬 - 데이터 양이 많을수록 오래걸려서 사용하진 않는다.
//1r = 1,4,2,5,3
//2r = 1,2,4,5,3
//3r = 1,2,3,5,4
//4r = 1,2,3,4,5


namespace Test._02
{
    internal class _2_04
    {
        static void Main1(string[] args)
        {
			int[] arr = { 4, 2, 1, 5, 3 };

			for (int i = 0; i < 4; i++)
			{
				for (int j = i + 1; j < 5; j++)
				{
					if (arr[i] > arr[j])
					{
						int temp = arr[j];
						arr[j] = arr[i];
						arr[i] = temp;
					}
				}
			}

			// 정렬된 배열 출력하기
			foreach (int n in arr)
			{
				Console.Write(n + " ");
			}




		}
    }
}
