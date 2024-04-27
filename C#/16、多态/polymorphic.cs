/*
C# 多态性
多态是同一个行为具有多个不同表现形式或形态的能力。
多态性意味着有多重形式。在面向对象编程范式中，多态性往往表现为"一个接口，多个功能"。
多态性可以是静态的或动态的。在静态多态性中，函数的响应是在编译时发生的。在动态多态性中，函数的响应是在运行时发生的。
在 C# 中，每个类型都是多态的，因为包括用户定义类型在内的所有类型都继承自 Object。
多态就是同一个接口，使用不同的实例而执行不同操作.


现实中，比如我们按下 F1 键这个动作：
        如果当前在 Flash 界面下弹出的就是 AS 3 的帮助文档；
        如果当前在 Word 下弹出的就是 Word 帮助；
        在 Windows 下弹出的就是 Windows 帮助和支持。

    同一个事件发生在不同的对象上会产生不同的结果。
    
静态多态性
在编译时，函数和对象的连接机制被称为早期绑定，也被称为静态绑定。C# 提供了两种技术来实现静态多态性。分别为：
    函数重载
    运算符重载

*/

/*
函数重载
您可以在同一个范围内对相同的函数名有多个定义。函数的定义必须彼此不同，可以是参数列表中的参数类型不同，也可以是参数个数不同。不能重载只有返回类型不同的函数声明。



动态多态性
C# 允许您使用关键字 abstract 创建抽象类，用于提供接口的部分类的实现。当一个派生类继承自该抽象类时，实现即完成。抽象类包含抽象方法，抽象方法可被派生类实现。派生类具有更专业的功能。
请注意，下面是有关抽象类的一些规则：
    您不能创建一个抽象类的实例。
    您不能在一个抽象类外部声明一个抽象方法。
    通过在类定义前面放置关键字 sealed，可以将类声明为密封类。当一个类被声明为 sealed 时，它不能被继承。抽象类不能被声明为 sealed。



当有一个定义在类中的函数需要在继承类中实现时，可以使用虚方法。
虚方法是使用关键字 virtual 声明的。
虚方法可以在不同的继承类中有不同的实现。
对虚方法的调用是在运行时发生的。
动态多态性是通过 抽象类 和 虚方法 实现的。
*/
using System;
using System.Collections.Generic;
namespace PolymorphismApplication
{
    public class TestData  
    {  
        public int Add(int a, int b, int c)  
        {  
            return a + b + c;  
        }  
        public int Add(int a, int b)  
        {  
            return a + b;  
        }
    }  
    
    class Printdata
    {
      	public void print(int i)
      	{
         	Console.WriteLine("输出整型: {0}", i );
      	}

      	public void print(double f)
      	{
         	Console.WriteLine("输出浮点型: {0}" , f);
      	}

      	public void print(string s)
      	{
         	Console.WriteLine("输出字符串: {0}", s);
      	}
    }
    
    
    abstract class Shape
   	{
		abstract public double area();
		
		// 虚方法
    	public virtual void Draw()
    	{
        	Console.WriteLine("执行基类的画图任务");
    	}
   	}
   	
   	class Rectangle : Shape
   	{
      	private double length;
      	private double width;
      	public Rectangle( double a=0, double b=0)
      	{
         	length = a;
         	width = b;
      	}
      	
      	public override double area ()
      	{
         	Console.WriteLine("Rectangle 类的面积：");
         	return (width * length);
      	}
      	
      	public override void Draw()
    	{
        	Console.WriteLine("画一个长方形");
        	base.Draw();
    	}
   	}
   	
   	
   	class Circle : Shape
	{	
		private double radius;
		public Circle(double r = 0) {
			radius = r;
		}
		
		
		public override double area ()
      	{
         	Console.WriteLine("Circle 类的面积：");
         	return (3.14 * radius * radius);
      	}
	
    	public override void Draw()
    	{
        	Console.WriteLine("画一个圆形");
        	base.Draw();
    	}
	}
	
	class Triangle : Shape
	{
		private double height;
		private double low;
		
		public Triangle(double h = 0, double l = 0) {
			height = h;
			low = l;
		}
		
		public override double area ()
      	{
         	Console.WriteLine("Triangle 类的面积：");
         	return (height * low * 0.5);
      	}
		
    	public override void Draw()
    	{
        	Console.WriteLine("画一个三角形");
        	base.Draw();
    	}
	}
   	
    
    class Program  
    {
    	static void Main(string[] args) {
    		test1();
    		test2();
    		
    		rectangleTester();
    		drawShape();
    	}
    	
        static void test1()
        {  
            TestData dataClass = new TestData();
            int add1 = dataClass.Add(1, 2);  
            int add2 = dataClass.Add(1, 2, 3);

            Console.WriteLine("add1 :" + add1);
            Console.WriteLine("add2 :" + add2);  
        }
        
        static void test2()
      	{
         	Printdata p = new Printdata();
         	// 调用 print 来打印整数
         	p.print(1);
         	// 调用 print 来打印浮点数
         	p.print(1.23);
         	// 调用 print 来打印字符串
         	p.print("Hello Runoob");
         	Console.ReadKey();
      	}
      	
      	static void rectangleTester()
      	{
         	Rectangle r = new Rectangle(10, 7);
         	Console.WriteLine("面积： {0}", r.area());
         	
         	Circle c = new Circle(10);
         	Console.WriteLine("面积： {0}",c.area());
         	
         	Triangle t = new Triangle(10, 7);
         	Console.WriteLine("面积： {0}",t.area());
         	
         	Console.ReadKey();
      	}
      	
      	static void drawShape()
    	{
        	// 创建一个 List<Shape> 对象，并向该对象添加 Circle、Triangle 和 Rectangle
        	var shapes = new List<Shape>
        	{
            	new Rectangle(),
            	new Triangle(),
            	new Circle()
        	};

        	// 使用 foreach 循环对该列表的派生类进行循环访问，并对其中的每个 Shape 对象调用 Draw 方法
        	foreach (var shape in shapes)
        	{
            	shape.Draw();
        	}

        	Console.WriteLine("按下任意键退出。");
        	Console.ReadKey();
    	}
    }  
}




















