using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        int[] ages = { 1, 3, 4, 5, 6, 7, 23, 54 }; 
        int agesSum = basicFunctions.calculateTotal(ages);
        
        double areaOfTriangle = basicFunctions.triangleArea(3, 4);
    }
}