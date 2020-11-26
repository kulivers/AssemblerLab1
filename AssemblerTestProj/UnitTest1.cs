using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Al = AssemblerLab1;

namespace AssemblerTestProj
{
    [TestClass]
    public class UnitTest1
    {
        public string CalcBin(int _commandNum, int _arg)//XXXX_XXXX
        {
            Func<int, string> MakeBin = x => Convert.ToString(x, 2);
            Func<string, string> SetZeros = binCmdNum =>
            {
                var builder = new StringBuilder(binCmdNum);
                //Debug.WriteLine("bin num before :" + builder);
                //Debug.WriteLine("bin num length before :" + builder.Length);
                if (builder.Length > 8)
                {
                    throw new Exception("Bin number is too big");
                }

                if (builder.Length < 8)
                {
                    while (builder.Length != 8)
                    {
                        builder.Append('0');
                    }
                }
                //Debug.WriteLine("bin num after :" + builder);
                return builder.ToString();
            };
            Func<string, string> set_ = str =>
            {
                var builder = new StringBuilder(str);

                if (str.Length == 8)
                {
                    //Debug.WriteLine("bin num before:" + builder);
                    builder.Insert(4, "_");
                    //Debug.WriteLine("bin num after :" + builder);
                    //bin num before: 10100000
                    //bin num after: 1010_0000
                }
                return builder.ToString();
            };

            return set_(SetZeros(MakeBin(_commandNum))) + "_????_" + MakeBin(_arg);
        }

        public Func<string, string> set_ = str =>
        {
            var builder = new StringBuilder(str);

            if (str.Length == 8)
            {
                //Debug.WriteLine("bin num before:" + builder);
                builder.Insert(4, "_");
                //Debug.WriteLine("bin num after :" + builder);
                //bin num before: 10100000
                //bin num after: 1010_0000
            }
            return builder.ToString();
        };
        [TestMethod]
        public void TestCalcBin()
        {
            var expected = "1011_0000_????_1100";
            var actual = CalcBin(11,12);
            Assert.AreEqual(expected,actual);
        }



    }

    [TestClass]
    public class LambdaTests
    {
        delegate void Message();


        public void cout1()
        {
            Debug.WriteLine("Message delegate1");
        }
        public void cout2()
        {
            Debug.WriteLine("Message delegate2");
        }
        public void cout3()
        {
            Debug.WriteLine("Message delegate3");
        }
        [TestMethod]
        public void DelegateTest1()
        {
            Message message = cout1;
            message += cout2;
            message += cout3;
            message -= cout3;
            message();

        }

        delegate int Square(int x); // объявляем делегат, принимающий int и возвращающий int
        Func<int, bool> equalsFive = x => x == 5;
        [TestMethod]
        public void lambdaTest()
        {
            //Square square = i => i * i; // объекту делегата присваивается лямбда-выражение
            //int z = square(6); // используем делегат
            //Debug.WriteLine(z); // выводит число 36

            //Debug.WriteLine(equalsFive(5));

        }
    }
}
