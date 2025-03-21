using System;

public class Solution 
{
    public string solution(string my_string, string letter) 
    {
        string answer = "";
        string[] array = my_string.Split(letter);
        
        for( int i = 0; i < array.Length; i++ )
        {
            answer += array[i];
        }
        return answer;
    }
}