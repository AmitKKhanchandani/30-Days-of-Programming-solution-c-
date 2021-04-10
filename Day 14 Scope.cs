using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

	// Add your code here
    
    public Difference(int[] element){
        this.elements = element;
    }
    public int computeDifference(){
        for(int i = 0; i < elements.Length - 1; i++){
            for(int j = 0; j < elements.Length; j++){
                int difference = Math.Abs(elements[i] - elements[j]);
                if(difference > maximumDifference){
                    maximumDifference = difference;
                }
            }
        }
        return maximumDifference;
    }
    

} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}