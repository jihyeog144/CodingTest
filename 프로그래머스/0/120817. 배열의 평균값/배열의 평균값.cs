using System;

public class Solution 
{
    public double solution(int[] numbers) 
    {
        double answer = 0;
        double total = 0;
        
        for(int i = 0; i < numbers.Length; i++)
        {
        total += numbers[i];
        }
        
        answer = total / numbers.Length;
        
        
        
        
        return answer;
        
        
        
        
    }
}