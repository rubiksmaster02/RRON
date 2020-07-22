﻿using System.Collections.Generic;
using RRON;

namespace RronTests
{
    public class Program
    {
        public static void Main()
        {
            TestClass settings = new TestClass
            {
                Bool      = true,
                Byte      = 1,
                Sbyte     = 2,
                Char      = '3',
                Double    = 5.0d,
                Float     = 6.0f,
                Int       = 7,
                Uint      = 8,
                Long      = 9,
                Ulong     = 10,
                Short     = 11,
                Ushort    = 12,
                String    = "13",
                Enum      = Enum.A,
                Struct    = new Vector2(14.0f, 15.0f),
                Class     = new InClass(16, 17),
                IntArray  = new[] {18, 19},
                IntList   = new List<int> {20, 21},
                EnumArray = new[] {Enum.A, Enum.B},
                EnumList  = new List<Enum> {Enum.C, Enum.D},
                StructArray = new[]
                {
                    new Vector2(25, 26),
                    new Vector2(27, 28)
                },
                StructList = new List<Vector2>
                {
                    new Vector2(29, 30),
                    new Vector2(31, 32)
                },
                ClassArray = new[]
                {
                    new InClass(33, 34),
                    new InClass(35, 36)
                },
                ClassList = new List<InClass>
                {
                    new InClass(37, 38),
                    new InClass(39, 40)
                },
                IntEnumerable  = new[] {41, 42},
                EnumEnumerable = new[] {Enum.A, Enum.B},
                StructEnumerable = new[]
                {
                    new Vector2(43, 44),
                    new Vector2(45, 46)
                },
                ClassEnumerable = new[]
                {
                    new InClass(47, 48),
                    new InClass(49, 50)
                }
            };
            RronSerializer.Serialize(settings);
        }
    }
}