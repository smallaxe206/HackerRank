using Microsoft.VisualStudio.TestTools.UnitTesting;
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

namespace HR01_SockColors
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NineSocksWith3Matches()
        {
            int n = 9;
            int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            Socks newSocks = new Socks();

            int numberOfPairs = Socks.SockMerchant(n, ar);

            Assert.AreEqual(3, numberOfPairs);
        }
    }

    public class Socks
    {
        public static int SockMerchant(int n, int[] ar)
        {
            List<int> sockCollection = new List<int>();
            int numberSockPairs = 0;
            
            //loop through array from 0 --> n and read each color in ar
            for (int i = 0; i < n; i++)
            {
                //check if current color in collection
                if (!sockCollection.Contains(ar[i]))
                {
                    //save sock colors in an array 
                    sockCollection.Add(ar[i]);
                }
                else
                {
                    sockCollection.Remove(ar[i]);
                    numberSockPairs++;
                }
            }

            return numberSockPairs;
        }
    }
}






    




