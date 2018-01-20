using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
       //Variables
        double mealCost=0,totalCost=0;
        int tipPercent=0,taxPercent=0;
        double tip=0,tax=0;
        
        //Input
        mealCost=Double.Parse(Console.ReadLine());
        tipPercent=Convert.ToInt32(Console.ReadLine());
        taxPercent=Convert.ToInt32(Console.ReadLine());
        
        //Alg
        tip = (mealCost * tipPercent)/100;
        tax = (mealCost * taxPercent)/100;
        totalCost=mealCost + tip + tax;
        
        //Output- Display
        Console.WriteLine("The total meal cost is {0} dollars.",Math.Round(totalCost));
    }
}