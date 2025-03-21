using System;

public class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        
        int a = 0;
        
       if(n/10>0) 
       {
           
           a = n/10;
           
         answer =  n * 12000 - a * 2000 + k * 2000;
           

       }
        
        else
        {
            answer = n* 12000 + k * 2000;
        }
        
        
        return answer;
    }
}