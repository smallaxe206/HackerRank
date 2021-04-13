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
    public class HR03_Clouds
    {
        [TestMethod]
        public void TestNumberOne()
        {
            //Arrange
            int[] c = new int[7] { 0, 0, 1, 0, 0, 1, 0 };
            Clouds clouds = new Clouds();

            //Act
            int jumps = Clouds.JumpingOnClouds(c);

            //Assert
            Assert.AreEqual(4, jumps);
        }

        [TestMethod]
        public void TestNumberTwo()
        {
            //Arrange
            int[] c = new int[6] { 0, 0, 0, 0, 1, 0 };
            Clouds clouds = new Clouds();

            //Act
            int jumps = Clouds.JumpingOnClouds(c);

            //Assert
            Assert.AreEqual(3, jumps);
        }

        [TestMethod]
        public void TestNumberThree()
        {
            //Arrange
            int[] c = new int[6] { 0, 0, 0, 1, 0, 0 };
            Clouds clouds = new Clouds();

            //Act
            int jumps = Clouds.JumpingOnClouds(c);

            //Assert
            Assert.AreEqual(3, jumps);
        }

    }

    public class Clouds
    {
        // Complete the jumpingOnClouds function below.
        public static int JumpingOnClouds(int[] c)
        {
            int numberOfJumps = 0;
            int index = 0;
            int targetIndex = c.Length - 1;

            while (index < targetIndex)
            {
                numberOfJumps++;

                if ((index+1 < targetIndex) && (c[index + 2] == 0))
                {
                    index = index + 2;
                }
                else
                {
                    index++;
                }
            }
            
            return numberOfJumps;
        }
    }
}






    




