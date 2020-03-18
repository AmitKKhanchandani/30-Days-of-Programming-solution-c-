using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {



    static void Main(string[] args) {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        var totalSum = -63;
        var curSum = 0;
        for (var i=0; i < arr.Length-2; i++) {
            for (var j=0; j < arr[i].Length-2; j++) {
                //                  //i=0; j=0     i=0; j=1    i=0; j=2    i=0; j=3
                curSum = arr[i][j] +     //arr[0][0]    arr[0][1]   arr[0][2]   arr[0][3]
                            arr[i][j+1] +   //arr[0][1]    arr[0][2]   arr[0][3]   arr[0][4]
                            arr[i][j+2] +   //arr[0][2]    arr[0][3]   arr[0][4]   arr[0][5]
                            arr[i+1][j+1] + //arr[1][1]    arr[1][2]   arr[1][3]   arr[1][4]
                            arr[i+2][j] +   //arr[2][0]    arr[2][1]   arr[2][2]   arr[2][3]
                            arr[i+2][j+1] + //arr[2][1]    arr[2][2]   arr[2][3]   arr[2][4]
                            arr[i+2][j+2];  //arr[2][2]    arr[2][3]   arr[2][4]   arr[2][5]
                if (curSum > totalSum) { //We're checking for MAX hourglass value, so if curSum is greater, set that one.
                    totalSum = curSum;
                }
            }
        }

        Console.WriteLine(totalSum);

    }
}
