﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableandBST.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> myMapNode = new MyMapNode<string, string>(19);
            myMapNode.Add("1", "Paranoids");
            myMapNode.Add("2", "are");
            myMapNode.Add("3", "not");
            myMapNode.Add("4", "paranoid");
            myMapNode.Add("5", "because");
            myMapNode.Add("6", "they");
            myMapNode.Add("7", "are");
            myMapNode.Add("8", "paranoid");
            myMapNode.Add("9", "but");
            myMapNode.Add("10", "because");
            myMapNode.Add("11", "they");
            myMapNode.Add("12", "keep");
            myMapNode.Add("13", "putting");
            myMapNode.Add("14", "themselves");
            myMapNode.Add("15", "deliberately");
            myMapNode.Add("16", "into");
            myMapNode.Add("17", "paranoid");
            myMapNode.Add("18", "avoidable");
            myMapNode.Add("19", "situations");
            //Console.WriteLine("Getting values by using {0}:{1}","4",myMapNode.Get("4"));
            myMapNode.Display();
            //Console.WriteLine(myMapNode.CountFrequency("paranoid"));
            Console.ReadLine();
        }
    }
}