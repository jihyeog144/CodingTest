using System;

public class Solution {
    public int solution(int age) {
        int answer = 0;
        
        answer = 2023 - (int)age;
    
        Console.WriteLine($"2022년 기준{age}살이므로{answer}년생입니다.");
        
        
        
        return answer;
    }
}