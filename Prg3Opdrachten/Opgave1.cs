﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace Prg3Opdrachten
{
    ////zie Blackboard voor opdrachten uitleg

    //Het idee is al volgt:
    //de meeste programmeertalen gebruiken diverse haakjes. 
    //Tegen over een open haakje moet een sluit haakje staan.
    //Het controleren van haakjes kan je met m.b.v. een stack.

    //het idee is dat je een methode maakt die controleert of de haakjes kloppen.
    //b.v.      "(3+2)/a[3+2]"      ==> true
    //          "(3+2/a[3+2]"       ==> false
    //          "[(({[]}))]{([])}"  ==> true
    //          "[(([]})]{[])}"     ==> false
    //De test methoden staan onderaan in Opgave1.cs

    public class Opgave1
    {
        private static List<char> openParenthesis = new List<char> {'(', '{', '['};
        private static List<char> closeParenthesis = new List<char> {')', '}', ']'};

        //opgave 1
        public static bool CheckParenthesis(string input)
        {
            IStack<char> par = StackFactory.CreateStack<char>();
            if (input == null) return true;
            foreach (char c in input)
            {
                if (openParenthesis.Contains(c))
                {
                    par.Push(c);
                }
                if (closeParenthesis.Contains(c))
                {
                    int index = 0;
                    for (int i = 0; i < closeParenthesis.Count; i++)
                    {
                        if (c == closeParenthesis[i])
                        {
                            index = i;
                            break;
                        }
                    }
                    if (par.Pop() != openParenthesis[index]) return false;
                }
            }
            if (par.Count > 0) return false;
            return true;
        }
    }

    class TestOpgave1
    {
        [Test]
        public void Test1() {

            string input = "a[(3+2)*3]";
            Assert.AreEqual(true, Opgave1.CheckParenthesis(input));
        }

        [Test]
        public void Test2()
        {
            string input = "a[(3+2)*3";
            Assert.AreEqual(false, Opgave1.CheckParenthesis(input));
        }

        [Test]
        public void Test3()
        {
            string input = "[(({[]}))]";
            Assert.AreEqual(true, Opgave1.CheckParenthesis(input));
        }

        [Test]
        public void Test4()
        {
            string input = "[(({[]})]";
            Assert.AreEqual(false, Opgave1.CheckParenthesis(input));
        }

        [Test]
        public void Test5()
        {
            string input = "[(({[]}))]{([])}";
            Assert.AreEqual(true, Opgave1.CheckParenthesis(input));
        }

        [Test]
        public void Test6()
        {
            string input = "[(({[]}))]{(])}";
            Assert.AreEqual(false, Opgave1.CheckParenthesis(input));
        }

        [Test]
        public void Test7()
        {
            string input = "[w(w(a{[b]}w))]{b(a[]w)}";
            Assert.AreEqual(true, Opgave1.CheckParenthesis(input));
        }

        [Test]
        public void Test8()
        {
            string input = "[w(w(a{[b]}w))]{b(a]w)}";
            Assert.AreEqual(false, Opgave1.CheckParenthesis(input));
        }

        [Test]
        public void TestSpaces()
        {
            string input = "  ";
            Assert.AreEqual(true, Opgave1.CheckParenthesis(input));
        }

        [Test]
        public void TestTabs()
        {
            string input = "\t\t";
            Assert.AreEqual(true, Opgave1.CheckParenthesis(input));
        }

        [Test]
        public void TestNull()
        {
            string input = null;
            Assert.AreEqual(true, Opgave1.CheckParenthesis(input));
        }
    }
}
