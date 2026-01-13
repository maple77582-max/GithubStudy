using System;
using System.Linq;

public class Solution
{
    public string solution(string my_string, int s, int e)
    {
        char[] array = my_string.ToArray();

        while (s < e) 
        {
            char temp = array[s];
            array[s] = array[e]; // 여기까진 char temp= array[s]= array[e]; 와 동일
            array[e] = temp;// temp에 저장된 값을 array[e]에 할당
            s++;//s가 점점 증가하게, 즉 배열의 s번째 부터 오른쪽으로 한칸씩 이동
            e--;//e가 점점 감소하게, 즉 배열의 e번째 부터 왼쪽으로 한칸씩 이동

            //s가 e보다 작아지면 while(s < e) 조건문이 false가 되어 반복문 종료
        }
        return new string(array);
    }
}