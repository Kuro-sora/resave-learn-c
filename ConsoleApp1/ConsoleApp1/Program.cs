

using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace ConsoleApp1
{

    public class Kuro
    {
        public int cc { get; set; }
        public string aa { get; set; }
        public static int ccc = 100;
        public static string aaa = "Thanks";

        //public Person(string _name, int _age)
        //{
        //    cc = _name;
        //    aa = _age;
        //}
    }


    class Kuro1


    {

        public Kuro1(int bb, string dd) 
        { 
            _bb = bb;
            _dd = dd;
        }

        private int _bb;
        public string _dd { get; private set; }

        static int _ccc = 200;
        public String _aaa { get; private set; }      //prop 隐士属性设置

        public int Bb                                      //_bb属性设置   GET SET属性设置
        {
            get
            {
                return _bb;
            }
            set
            {
                if (value > 110)
                {
                    Console.WriteLine("参数超过最大值");
                    throw new ArgumentException();
                }
                else {
                    _bb = value;
                }
                
            }
        }


        public void info() 
        {
            Console.WriteLine($"My name is {_dd},and I am {_bb} years old.");
        }




        class Program
        {



            void func()
            {
                Console.WriteLine("13441");
            }
            static int func1(int _number)
            {
                return (_number + 5) * 2;
            }
            static int func2(int _number)
            {
                return _number / 2 - 5;
            }

            static bool Mytest(ref int Number, out float result)           //ref 作为引用传递参数    in代表只读
            {

                Number = 999999;
                result = 9.9999f;

                return true;

            }
            static void Msg(string msg, int level = 0)                      //增加默认参数 默认参数后面必须接默认参数
            {
                Console.WriteLine($"[LEVEL:{level}]: {msg}");

            }



            static int Getsum(params int[] numbers)        //params参数数组，必须放在最后一个    
            {
                int result = 0;
                foreach (int i in numbers)
                    result += i;
                return result;
            }
            static void Main()
            {

                Kuro k = new();                    //类的对象引用
                k.cc = 1;
                k.aa = "kuuooooo";
                Console.WriteLine(Kuro.ccc);
                Console.WriteLine(Kuro.aaa);


                //var reg5 = 9;
                int reg = 20;
                string arr = "wo";
                double pi = 5.236841;
                float high = 0.9862F;
                decimal money = 99.621M;
                bool rb = false;
                char A = 'a';
                short re = 10;
                reg = re;
                re = (short)reg;
                Console.WriteLine(reg);
                Console.WriteLine(arr);
                Console.WriteLine(high);
                Console.WriteLine(pi);
                Console.WriteLine(money);
                Console.WriteLine(rb);
                Console.WriteLine(A);

                Console.WriteLine(!rb ? 11111 : 22222);

                int reg2 = 88;
                int reg3 = 99;
                int result = reg2 + reg3;

                Console.WriteLine("reg2 + reg3 = " + $"{reg2}+{reg3}={result}");


                int result1;
                int result2;

                result = func1(20);
                Console.WriteLine("func1=" + result);
                result = func2(result);
                Console.WriteLine("func2=" + result);

                static int SetInt(int i, int newi)
                {
                    return i = newi;
                }

                int v = 999;
                SetInt(v, 888);

                Console.WriteLine(SetInt);
                Console.WriteLine(v);                    //v作为副本被引用，并不会改变本体。



                int[] array = { 8, 6, 4, 9, 1, 0, 5, 7, 3, 2, 11, 19, 21 };
                int[] array1 = new int[array.Length];
                //Console.WriteLine(array.Length);
                int[,] array2 = { { 1, 3, 0, 9 }, { 1, 3, 0, 9 }, { 1, 3, 0, 9 } }; //二维数组


                //Console.WriteLine(array1.GetLength(1));         //0/1 数组数量和元素个数
                //int int1;
                //for (int i = 0; i < array.Length-1; i++)           //排序
                //{
                //    for (int j = 0; j < array.Length - 1-i; j++)
                //{

                //    if (array[j] > array[j + 1])
                //    {
                //        int1 = array[j];
                //        array[j] = array[j + 1];
                //        array[j + 1] = int1;
                //    }
                //} 
                //} 

                //foreach (int aa in array)
                //{
                //    Console.Write(aa);
                //}


                //int intp = int.Parse(Console.ReadLine());    //强制转换int


                //for (int i = 1; i < 10; i++)               //99乘法表
                //{

                //    for (int j = 1; j <= i; j++)
                //    {
                //        Console.Write($"{j} * {i} = {j * i}\t");
                //    }
                //    Console.WriteLine();
                //}


                //while (true)
                //{
                //    try
                //    {
                //        string revice = Console.ReadLine();
                //        if (revice == "q")
                //        {
                //            Console.WriteLine("程序已结束");
                //            break;
                //        }
                //        else
                //        {
                //            //Console.WriteLine("您输入的是："+ revice);
                //        }

                //    }
                //    catch (ArgumentNullException)
                //    {

                //        Console.WriteLine("请输入参数");
                //    }
                //    catch (FormatException)
                //    {

                //        Console.WriteLine("请输入数字");
                //    }
                //    catch (OverflowException)
                //    {

                //        Console.WriteLine("长度超限");
                //    }
                //}


                int Number = 100;                  //ref 作为引用传递参数    in代表只读
                float r;
                Mytest(ref Number, out r);
                Console.WriteLine(Number);
                Console.WriteLine(r);
                Console.WriteLine(Getsum(1, 3, 5, 7, 9, 11, 13, 15, 17, 19));     //参数数组
                Msg("OK");                                               //默认传参
                Msg("NG", 1);                                            //指定传参

                Kuro1 k1 = new Kuro1(18,"Yama");
                Kuro1 k2 = new Kuro1(15, "Jerry");
                Kuro1 k3 = new Kuro1(17, "Yawasaki");
                k1.info();
                k2.info();
                k3.info();


            }
        }
    }
}




















