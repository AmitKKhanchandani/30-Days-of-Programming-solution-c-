using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var n = int.Parse(Console.ReadLine());
        Dictionary<string,int> phoneBook = new Dictionary<string,int>();
        
        //Phase 1 - inserting the data into the Phone Book directory
        for(int i=0;i<n;i++){
            var phoneBookEntry=Console.ReadLine().Split(' ');
            var name=phoneBookEntry[0];
            var phone=int.Parse(phoneBookEntry[1]);
            phoneBook.Add(name,phone);
        }
        
        //Phase 2 - Reading and Output the found Names in the Phone Book
        for(int i=0;i<n;i++){
            var searchName=Console.ReadLine();
            if(phoneBook.ContainsKey(searchName)){
                var phoneNumber=phoneBook[searchName];
                Console.WriteLine($"{searchName}={phoneNumber}");
            }
            else{
                Console.WriteLine("Not found");
            }
        }
    }
}