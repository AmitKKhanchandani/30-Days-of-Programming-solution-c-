using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int input=int.Parse(Console.ReadLine());
        
        for(int i=0; i<input;i++){
            String strInput=Console.ReadLine();
            //Even Indices
            for(int j=0;j<strInput.Length;j++){
                if(j % 2 ==0) Console.Write(strInput[j]);
            }
            
            //Space in Between Even and Old Indices
            Console.Write(" ");
            
            //OLD Indices
            for(int j=0;j<strInput.Length;j++){
                if(j % 2 !=0) Console.Write(strInput[j]);
            }
            Console.WriteLine();
        }
    }
}