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

namespace HackerRankInterviewQuestionUnitTests
{
    [TestClass]
    public class HR02_Valleys
    {
        [TestMethod]
        public void NumberOfValleysOneValley()
        {
            int n = 8;
            string steps = "UDDDUDUU";
            Valleys valleys = new Valleys();

            int numOfValleys = Valleys.CountingValleys(n, steps);

            Assert.AreEqual(1, numOfValleys);
        }

        [TestMethod]
        public void NumberOfValleysTwoValley()
        {
            int n = 10;
            string steps = "DUUDDDUUUD";
            Valleys valleys = new Valleys();

            int numOfValleys = Valleys.CountingValleys(n, steps);

            Assert.AreEqual(2, numOfValleys);
        }
    }

    public class Valleys
    {
        public static int CountingValleys(int steps, string path)
        {
            int numberOfValleys = 0;
            string upOrDown = string.Empty;
            int pointInHike = 0;
            bool inValley = false;
            
            for (int i = 0; i < steps; i++)
            {
                upOrDown = path.Substring(i, 1);
                if (upOrDown == "D")
                    pointInHike--;
                else
                    pointInHike++;

                if (pointInHike < 0 && inValley == false)
                {
                    inValley = true;
                    numberOfValleys++;
                }
                else if (pointInHike >= 0)
                {
                    inValley = false;
                }
            }

            return numberOfValleys;
        }
    }
}






    




