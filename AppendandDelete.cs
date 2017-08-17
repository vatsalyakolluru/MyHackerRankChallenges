using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine());
        
        int s_len = s.Length;
        int t_len = t.Length;
        if ((k > 100) || (k < 1)) return;
        if ((s_len > 100) || (s_len < 1)) return;
        if ((t_len > 100) || (t_len < 1)) return;
         
                
        if(s == t)
        {
            Console.WriteLine("Yes");
            return;
        }       
        
        for (int i=0;i<k;i++){
            if (t.IndexOf(s) > -1)
            {
                string t_1 = t;
                string remain = t_1.Replace(s, "");
                if(remain.Length <= (k-i))   
                {
                    if(remain.Length == 1)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
            }
            if ((s.Length == 0) && ((k-i) >= t_len)) {
                Console.WriteLine("Yes");
                return;
            }
            s = s.Substring(0, s.Length - 1);
            if (t.IndexOf(s) > -1)
            {
                string t_1 = t;
                string remain = t_1.Replace(s, "");
                if(remain.Length <= (k-i))   
                {
                    if(remain.Length == 1)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
            }
            
        }
        Console.WriteLine("No");
        return;
    }
}
