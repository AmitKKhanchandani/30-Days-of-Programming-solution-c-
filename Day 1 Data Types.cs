using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        
        // Declare second integer, double, and String variables.
        int ii=Convert.ToInt32(Console.ReadLine());
        double dd=Convert.ToDouble(Console.ReadLine());
        string s2=Console.ReadLine();
        // Read and save an integer, double, and String to your variables Concatenate.
        ii=ii+i;
        dd=dd+d;
        s=s+s2;
        
        //Print
        Console.WriteLine(ii);
        Console.WriteLine(dd.ToString("N1"));
        Console.WriteLine(s);
        
    }
}