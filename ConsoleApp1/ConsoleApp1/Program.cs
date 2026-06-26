

using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace ConsoleApp1
{

    interface operation                                 //interface接口  通过接口实现多态
    {
        void Num(int a,int b);

    }

    class Add : operation                           // 子类继承
    {
        public void Num(int a, int b)
        {
            Console.WriteLine($"[调用加法]: {a} + {b} = {a + b}");
        }
    }

    class Sub : operation
    {
        public void Num(int a, int b)
        {
            Console.WriteLine($"[调用减法]: {a} - {b} = {a - b}");
        }
    }
    class Mul : operation
    {
        public void Num(int a, int b)
        {
            Console.WriteLine($"[调用乘法]: {a} * {b} = {a * b}");
        }
    }
    class Div : operation
    {
        public void Num(int a, int b)
        {
            Console.WriteLine($"[调用除法]: {a} / {b} = {a / b}");
        }
    }

    class Kuro
    {   
          public Kuro(int _Height )              //构造函数 初始化每个一个成员  ctor
        {
            Height = _Height;
            //Width = _Width;
            //Depth = _Depth;
            
        }

        public int cc { get; set; }               //prop快捷设置成员属性
        public string aa { get; set; }
        public static int ccc = 100;
        public static string aaa = "Thanks";
        

        private int height;
        private int width;
        private int depth;

         public int Height                         //属性设置  每一个成员的 GET SET属性设置 
        {
            get { 
            
                return height;
            }
            set 
            {
                if (value<0 || value > 999)
                {
                    Console.WriteLine("高度值超出范围");
                    throw new ArgumentException();
                }
                height = value;
            }
        }
        public int Width
        {   
            get
            {
                return width;
            }
            set 
            {
                if (value < 0 || value > 999)
                {
                    Console.WriteLine("宽度值超出范围");
                    throw new ArgumentException();
                }
                width = value;
            }
        }
        public int Depth
        {
            get { return depth; }
            set { 
                if (value < 0 || value > 999)
                {
                    Console.WriteLine("深度值超出范围");
                    throw new ArgumentException();
                }
                depth = value;
            }
        }
        public void volume()
        {
            Console.WriteLine($"您输入的物体体积为: {height}*{width}*{depth} = {height * width * depth}");
        }

        public virtual void info()                      //Virtual 关键字允许在派生类中重写方法 定义基类为虚方法
        {
            Console.WriteLine("This's Kuro");
        }


        //public Person(string _name, int _age)
        //{
        //    cc = _name;
        //    aa = _age;
        //}

    }
        class zfx: Kuro
    {
        public zfx(int _Height) : base(_Height) { base.Depth = 10; }   //继承父类的构造函数
        public override void info()                               //override 关键字允许在派生类中重写方法 定义派生类为重写方法
        {
            Console.WriteLine("This's zfx");
        }
    }

    class cfx : Kuro
    {
        public cfx(int _Height) : base(_Height) { }          //继承父类的构造函数
        public override void info()                         //override 关键字允许在派生类中重写方法 定义派生类为重写方法
        {
            Console.WriteLine("This's cfx");
        }
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

        enum Color { Red, Green, Blue,Pink,Yellow };             //枚举类型 实际是int类型  默认从0开始  可以指定值


        public struct encrypt                                    //隐式类型转换  通过implicit关键字实现
        {
            public int t1, t2, t3;

            public encrypt(int t1, int t2, int t3)
            {
                this.t1 = t1;
                this.t2 = t2;
                this.t3 = t3;
            }
            public void show()
            {
                Console.WriteLine($"MyStruct: {t1}, {t2}, {t3}");
            }
            public static implicit operator encrypt(decrypt a)
            {
                return new (a.t1, a.t2, a.t3);
            }

        }
        public struct decrypt                                               //显式类型转换  通过explicit关键字实现
        {
            public int t1, t2, t3;

            public decrypt(int t1, int t2, int t3)
            {
                this.t1 = t1;
                this.t2 = t2;
                this.t3 = t3;
            }
            public void show()
            {
                Console.WriteLine($"MyStruct: {t1}, {t2}, {t3}");
            }
            public static explicit operator decrypt(encrypt a)            
            {
                return new(a.t1, a.t2, a.t3);
            }
        }



            public void info() 
        {
            Console.WriteLine($"My name is {_dd},and I am {_bb} years old.");
        }

        class Program
        {


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

            static void Getin(operation num) 
            {
                num.Num(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
            }
            static void Main()
            {






                                                         //隐式类型转换和显式类型转换
                //encrypt v1 = new (1, 2, 3);
                //decrypt v2 = new(4, 5, 6);
                //v2 = (decrypt)v1;
                //v1 = v2;


                //MyStruct myStruct;                   // 结构体实例化 需要初始化字段，或者默认初始化 MyStruct myStruct = new（）
                //myStruct.t1 = 1; myStruct.t2=2; myStruct.t3 = 2;
                //myStruct.show();



                //Color color = Color.Pink;                  //枚举类型
                //int color1 = (int)Color.Red;              //枚举类型转换为int类型




                //operation add = new Add();                   //static多态 通过接口实现多态         
                //operation sub = new Sub();
                //operation mul = new Mul();
                //operation div = new Div();
                //Getin(div);





                //用构造函数初始化类的成员属性
                //Console.WriteLine("请输入物体的高度X宽度X深度:");         
                //Kuro kk = new Kuro(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                //Kuro kk1 = new Kuro(10, 20, 30);

                //kk.volume();


                //Kuro KK2 = new Kuro(50)                        //快速初始化语句，初始化顺序在构造函数之后。
                //{
                //    Width = 20,Depth = 100
                //};
                //KK2.volume();


                //继承基类属性和方法，并且调用父类的构造函数初始化成员属性

                //zfx zfx = new(int.Parse(Console.ReadLine()));
                //zfx.info(); 
                //zfx.volume();

                //cfx cfx = new(int.Parse(Console.ReadLine()));
                //cfx.info(); 
                //cfx.volume();


                //Kuro zfx1= new zfx(int.Parse(Console.ReadLine()));    //子类继承方法重载。根据具体实例选择方法
                //zfx1.info();
                //Kuro cfx1 = new cfx(int.Parse(Console.ReadLine()));
                //cfx1.info();




                //Kuro k = new();                    //类的对象引用
                //k.cc = 1;
                //k.aa = "kuuooooo";
                //Console.WriteLine(Kuro.ccc);
                //Console.WriteLine(Kuro.aaa);


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


                //int Number = 100;                  //ref 作为引用传递参数    in代表只读
                //float r;
                //Mytest(ref Number, out r);
                //Console.WriteLine(Number);
                //Console.WriteLine(r);
                //Console.WriteLine(Getsum(1, 3, 5, 7, 9, 11, 13, 15, 17, 19));     //参数数组
                //Msg("OK");                                               //默认传参
                //Msg("NG", 1);                                            //指定传参

                //Kuro1 k1 = new Kuro1(18,"Yama");
                //Kuro1 k2 = new Kuro1(15, "Jerry");
                //Kuro1 k3 = new Kuro1(17, "Yawasaki");
                //k1.info();
                //k2.info();
                //k3.info();







            }
        }
    }
}




















