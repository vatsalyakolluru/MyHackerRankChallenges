using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        for (int i=0; i< k;i++)
        {
            if ((a[i] > Math.Pow(10,6)) || (a[i] < 1))
            { 
                return;
            }
        }
        if ((n <= Math.Pow(10,5)) && (n >= 1))
        {
            if ((k <= n) && (k >= 1))
            {
                for (int i=0; i< k;i++)
                {
                    List<int> newA = new List<int>();
                    int y = a[0];
                    for (int z = 1; z < a.Length; z++)
                    {
                        newA.Add(a[z]);       
                    }  
                    newA.Add(y);
                    a = newA.ToArray();
                }     
               int [] terms = a.ToArray();
               for (int j = 0; j<terms.Length;j++)
               {Console.Write(terms[j]+" ");}
                return;
                
            }
        }
       return; 
    }
}
