using System;

public class Solution
{
    public int solution(int a, int b, int c)
    {
        if (a == b && b == c)
        {
            return (int)((a + b + c) * (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)) * (Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3)));
        } // a, b, c가 모두 같을 때 (a+b+c) x (a^2+b^2+c^) x (a^3+b^3+c^3)을 반환합니다.

        else if (a == b || b == c || a == c)
        {
            return (int)((a + b + c) * (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)));
        } // a, b, c 중 두 개가 같을 때 (a+b+c) x (a^2+b^2+c^2)을 반환합니다.
        else
        {
            return a + b + c;
        } // a, b, c가 모두 다를 때 a+b+c를 반환합니다.
    }
}