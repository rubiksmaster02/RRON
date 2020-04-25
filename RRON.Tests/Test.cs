﻿using System.Collections.Generic;

public class TestClass
{
    public TestClass(int number, string word, bool boolean, float f, double d, List<ClassInClassTest> tests)
    {
        Number = number;
        Word = word;
        Boolean = boolean;
        Float = f;
        Double = d;
        Test = tests;
    }
    
    public TestClass() { }

    public int Number { get; set; }
    public string Word { get; set; }
    public bool Boolean { get; set; }
    public float Float { get; set; }
    public double Double { get; set; }
    public List<ClassInClassTest> Test { get; set; }

}

public class ClassInClassTest
{
    public ClassInClassTest(int t1, int t2, int t3)
    {
        Test1 = t1;
        Test2 = t2;
        Test3 = t3;
    }

    public int Test1 { get; set; }
    public int Test2 { get; set; }
    public int Test3 { get; set; }
}