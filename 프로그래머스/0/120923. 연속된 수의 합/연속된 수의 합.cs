using System;

public class Solution
{
    public int[] solution(int num, int total)
    {
        int[] answer = new int[num];

        // 중간값. '/'는 몫만 나오기 때문에 평균을 구하면 자연스럽게 왼쪽(작은) 값을 고르게 된다.
        int middle = total / num;

        // 시작값
        int start = middle - (num - 1) / 2;

        // 나머지 배열 채우기
        for (int i = 0; i < num; i++)
        {
            answer[i] = start + i;
        }

        return answer;
    }
}