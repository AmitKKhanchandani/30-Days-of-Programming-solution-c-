using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        int number;
        try{
            number = Int32.Parse(S);
            Console.WriteLine(number);
        }
        catch{
            Console.WriteLine("Bad String");
        }
    }
}