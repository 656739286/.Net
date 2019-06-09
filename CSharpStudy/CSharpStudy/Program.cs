/**********************************************************
Created by : LXL 
CreateTime:2019/5/15 19:32
Title:测试
**********************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CSharpStudy
{

    class Program
    {
        static void Main(string[] args)
        {
            YieldCollection yieldCollection = new YieldCollection();
            foreach (var item in yieldCollection)
            {

            }

            Console.ReadKey();
        }
    }

    

    public class YieldCollection : IEnumerable
    {
        int[] arrs = new int[] { 1, 2, 3, 4, 5, 6 };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < arrs.Length; i++)
            {
                if (i < 5)
                {
                    yield return arrs[i];
                }
                else
                {
                    yield break;
                }
            }
        }
    }
}
