//using System;

//namespace netdemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}


//using System;


//namespace netdemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("hello world");
//            Console.ReadKey();
//        }
//    }


//}



using System;
//namespace Rectangle{
//    class Rectangle{

//        double length;
//        double width;
//        public void Acceptdetails()
//        {
//            length = 4.5;
//            width = 3.5;

//        }

//        public double GetArea()
//        {
//            return length * width;
//        }



//        public void Display()

//        {
//            Console.WriteLine("Length:{0}",length);
//            Console.WriteLine("Width:{0}",width);
//            Console.WriteLine("Area:{0}", GetArea());


//        }


//    }


//    class ExecuteRectangle
//    {
//        static void Main (String[] args)
//        {
//            int number;
//            number = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(number);
//            Rectangle r = new Rectangle();
//            r.Acceptdetails();
//            r.Display();
//            Console.ReadLine();
//        }
//    }





//}



//死循环
//namespace Loops 
//{
//    class Progrm
//    {
//        public int b = 2;
//        static void Main(string[] args)
//        {

//            int a = 0;
//            for (; ; )
//            {
//                a++;
//                Console.WriteLine("hello i am trapped{0}",a);

//            }



//        }



//    }

//}




//选择最大值
//namespace CalculatorApplication
//{
//    class NumberManipulator
//    {
//        public int FindMax(int num1,int num2)
//        {
//            int result;
//            if (num1 > num2)
//                result = num1;
//            else
//                result = num2;
//            return result;

//        }


//    static void Main(string[] args)
//    {
//        int a = 100;
//        int b = 200;
//        int ret;
//        NumberManipulator n = new NumberManipulator();
//        ret = n.FindMax(a, b);
//        Console.WriteLine("最大值是:{0}", ret);
//            Console.ReadLine();
//    }

//    }

//}



//循环递归
//namespace CalculatorAppliction
//{
//    class NumberMainpulator
//    {
//        public int factorial(int num)
//        {
//            int result;
//            if (num == 1)
//            {
//                return 1;
//            }
//            else
//            {
//                result = factorial(num - 1) * num;
//                return result;
//            }
//        }
//        static void Main(string[] args)
//        {

//            NumberMainpulator n = new NumberMainpulator();
//            Console.WriteLine("6的阶乘是:{0}", n.factorial(6));
//            Console.ReadLine();
//        }

//    }
//}


//namespace Calculator

//{

//    class NumberMainpulator
//    {
//        public void swap (ref int x,ref int y)
//        {
//            int temp;

//            temp = x;
//            x = y;
//            y = temp;

//        }

//        static void Main(string[] args)
//        {
//            NumberMainpulator n = new NumberMainpulator();
//            int a = 100;
//            int b = 200;

//            Console.WriteLine("在交换之前a的值：{0}", a);
//            Console.WriteLine("在交换之前b的值：{0}", b);

//            n.swap(ref a,ref b);
//            Console.WriteLine("在交换之后a的值：{0}", a);
//            Console.WriteLine("在交换之后b的值：{0}", b);

//            Console.ReadLine();
//        }

//    }

//}



//数组操作
//namespace arr
//{


//    class MyArray
//    {
//        static void Main(String[] args)
//        {

//            int[] n = new int[10];
//            int i, j;
//            for (i = 0;i < 10;i++)
//            {
//                n[i] = i + 100;

//            }

//            for (j = 0; j < 10;j++)
//            {
//                Console.WriteLine("element [{1} ]is {0}", n[j],j);
//            }
//            Console.ReadKey();
//        }
//    }

//}


//foreach循环

//namespace  ArrForeach
//{

//    class ForEach
//    {

//        static void Main(string[] args)
//        {
//            int[] n = new int[10];
//            for (int i = 0; i < 10;i++)
//            {
//                n[i] = i + 100;
//            }

//            foreach (int j in n)
//            {
//                int i = j - 100;
//                Console.WriteLine("element[{0}] = {1}", i, j);

//            }
//            Console.ReadKey();


//        }




//    }




//}




//String 字符串

//namespace StringApplication
//{

//    class Program
//    {

//        static void Main(string[] args)
//        {


//            //字符串拼接
//            string fname, lname;
//            fname = "Rowan";
//            lname = "Atkinson";
//            string fullname = fname + lname;
//            Console.WriteLine("Full Name : {0}", fullname);

//            //通过使用Strin构造函数

//            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
//            string greetings = new string(letters);
//            Console.WriteLine("Greetings:{0}", greetings);


//            //方法返回字符串

//            string[] sarray = { "hello", "frome", "tutorials", "Point" };
//            string message = String.Join(" ", sarray);
//            Console.WriteLine("Message:{0}", message);


//            //用于转化值的格式化方法

//            DateTime waiting = new DateTime(2012, 10, 10, 12, 58, 1);
//            string chat = string.Format("Message sent at {0:t}on {0:D}", waiting);

//            Console.WriteLine("Message:{0}", chat);
//            Console.ReadKey();

//        }




//    }




//}


//结构体
//struct Books
//{
//    public string title;
//    public string author;
//    public string subject;
//    public int book_id;


//};


//public class tstStructure
//{

//    public static void Main(string[] args)
//    {
//        Books Book1;
//        Books Book2;

//        Book1.title = "C Programming";
//        Book1.author = "Nuha Ali";
//        Book1.subject = "C Programming Tutorial";
//        Book1.book_id = 6495407;

//        Book2.title = "Telecom Billing";
//        Book2.author = "Zarz Ali";
//        Book2.subject = "Telecom Billing Tutorial";
//        Book2.book_id = 6495700;


//        Console.WriteLine("Book 1 title:{0}", Book1.title);
//        Console.WriteLine("Book 1 author:{0}", Book1.author);
//        Console.WriteLine("Book 1 subject: {0}", Book1.subject);
//        Console.WriteLine("Book 1 book_id:{0}", Book1.book_id);


//        Console.WriteLine("Book 2 title:{0}", Book2.title);
//        Console.WriteLine("Book 2 author:{0}", Book2.author);
//        Console.WriteLine("Book 2 subject: {0}", Book2.subject);
//        Console.WriteLine("Book 2 book_id:{0}", Book2.book_id);

//        Console.ReadKey();

//    }


//}




//枚举
//public class EnumTest
//{
//    enum Days { sun, Mon, Tue, Web, Thu, Fri, Sat };
//    static void Main()
//    {
//        int x = (int)Days.sun;
//        int y = (int)Days.Fri;
//        Console.WriteLine("Sun = {0}", x);
//        Console.WriteLine("fri = {0}", y);
//    }
//}



//public  class kevin 
//{

//    public int value1;
//    public int value2;

//}



//类
//namespace Boxapplication
//{

//    class Box
//    {
//        public double length;
//        public double breadth;
//        public double height;



//    }


//    class Boxtester
//    {
//        static void Main(string[] args)
//        {

//            Box Box1 = new Box();
//            Box Box2 = new Box();
//            double volume = 0.0;

//            Box1.height = 5.0;
//            Box1.length = 6.0;
//            Box1.breadth = 7.0;


//            Box2.height = 10.0;
//            Box2.length = 6.0;
//            Box2.breadth = 13.0;

//            volume = Box1.height * Box1.length * Box1.breadth;
//            Console.WriteLine("Box1 的体积是：{0}", volume);


//            volume = Box2.height * Box2.height * Box2.breadth;
//            Console.WriteLine("Box2 的体积是：{0}", volume);


//        }


//    }

//}



//类的成员函数和封装
//namespace BoxApplication
//{
//    class Box
//    {
//        private double length;
//        private double breadth;
//        private double height;
//        public void setLength(double len)
//        {
//            length = len;
//        }
//        public void setBreadth(double bre)
//        {
//            breadth = bre;
//        }

//        public void setHeight(double hei)
//        {
//            height = hei;
//        }
//        public double getVolume()
//        {
//            return length * breadth * height;

//        }


//    }

//    class Boxtester
//    {

//        static void Main(string[] args)
//        {
//            Box Box1 = new Box();
//            Box Box2 = new Box();
//            double volume;

//            Box1.setLength(6.0);
//            Box1.setHeight(5.0);
//            Box1.setBreadth(7.0);



//            Box2.setLength(12.0);
//            Box2.setBreadth(13.0);
//            Box2.setHeight(10.0);

//            volume = Box1.getVolume();
//            Console.WriteLine("Box1的体积:{0}", volume);
//            Console.WriteLine("Box2的体积:{0}", volume);

//            Console.ReadKey();





//        }


//    }

//}



//构造函数  

//namespace LineApplication
//{
//    class Line
//    {
//        private double length;
//        public Line()
//        {
//            Console.WriteLine("对象已经创建");

//        }
//        //析构函数
//        ~Line()
//        {

//            Console.WriteLine("对象已删除");

//        }

//        public void setLength(double len)
//        {
//            length = len;

//        }

//        public double getLength()
//        {
//            return length;

//        }

//        static void Main(String[] args)
//        {

//            Line line = new Line();
//            line.setLength(6.0);
//            Console.WriteLine("线条的长度{0}", line.getLength());
//            Console.ReadKey();
//        }

//    }



//}


//静态变量

//namespace StaticVarApplication
//{
//    class StaticVar
//    {
//        public static int num;
//        public void count()
//        {
//            num++;

//        }
//        public int getNum()
//        {
//            return num;
//        }
//    }
//    class StaticTester
//    {
//        static void Main(string[] args)
//        {
//            StaticVar s1 = new StaticVar();
//            StaticVar s2 = new StaticVar();
//            s1.count();
//            s1.count();
//            s1.count();
//            s2.count();
//            s2.count();
//            s2.count();
//            Console.WriteLine("S1的变量 num:{0}", s1.getNum());
//            Console.WriteLine("s2的变量 num：{0}", s2.getNum());
//            Console.ReadKey();

//        }
//    }
//}

//继承
namespace InheritanceApplication
{
    class Shape
    {
        public void setwidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }

        protected int width;
        protected int height;


    }

    class Rectangle:Shape
    {


        public int getArea()
        {
            return (width * height);
        }

    }



    class RectangleTester
    {
        static void Main(string[] atgs)
        {
            Rectangle Rect = new Rectangle();
            Rect.setwidth(5);
            Rect.setHeight(7);
            Console.WriteLine("总面积{0}", Rect.getArea());
            Console.ReadKey();
        }
    }


}


//基类的初始化

namespace RectangApplication
{

    class Rectangle
    {
        protected double length;
        protected double width;
        public Rectangle(double l,double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("长度:{0}", length);
            Console.WriteLine("宽度:{0}", width);
            Console.WriteLine("面积{0}", GetArea());

        }



    }



}