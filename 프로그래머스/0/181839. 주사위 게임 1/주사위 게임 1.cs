using System;

    public class Solution
    {
        public int solution(int a, int b)
        {
            if (a % 2 == 1 && b % 2 == 1)
            {
            return (int)(Math.Pow(a, 2) + (int)Math.Pow(b, 2)); // a와 b가 모두 홀수 일 때 a 2제곱 b 2제곱의 합을 반환합니다.
        }
            else if (a % 2 == 1 || b % 2 == 1)
            {
                return 2 * (a + b); // a와 b 중 하나라도 홀수 일 때 (a+b)의 2배를 반환합니다.
            }
            else
            {
                return (int)Math.Abs(a - b); // 그 외의 경우(둘 다 짝수일 경우) |a-b|를 반환합니다.
            }
        }
    }
