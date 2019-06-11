/**********************************************************
Created by : LXL 
CreateTime:2019/5/15 19:32
Title:测试
**********************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace CSharpStudy
{

    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "str");
            hashtable.Add("lll", 123);
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(hashtable[item]);
            }
            Console.ReadKey();
        }
    }
}
