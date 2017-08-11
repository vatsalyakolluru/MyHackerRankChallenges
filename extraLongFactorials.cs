using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        BigInteger x = 1;        
        if (n > 100 || n < 1)
        {
            Console.WriteLine("");
            return;
        }
        for (int i=1; i < n; i++)
        {
            x = x*(n-i);
        }
        x = n * x;
        Console.WriteLine(x);
        return;
    }
}