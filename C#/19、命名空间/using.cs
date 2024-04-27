/*
using 关键字
using 关键字表明程序使用的是给定命名空间中的名称。例如，我们在程序中使用 System 命名空间，其中定义了类 Console。我们可以只写：
Console.WriteLine ("Hello there");

我们可以写完全限定名称，如下：
System.Console.WriteLine("Hello there");

您也可以使用 using 命名空间指令，这样在使用的时候就不用在前面加上命名空间名称。该指令告诉编译器随后的代码使用了指定命名空间中的名称。


using的用法：
1. using指令：引入命名空间
这是最常见的用法，例如：
using System;
using Namespace1.SubNameSpace;

2. using static 指令：指定无需指定类型名称即可访问其静态成员的类型
using static System.Math;var = PI; // 直接使用System.Math.PI

3. 起别名
using Project = PC.MyCompany.Project;

4. using语句：将实例与代码绑定
using (Font font3 = new Font("Arial", 10.0f),
            font4 = new Font("Arial", 10.0f))
{
    // Use font3 and font4.
}

代码段结束时，自动调用font3和font4的Dispose方法，释放实例。
*/

using System;
using first_space;
using second_space;

namespace first_space
{
   	class abc
   	{
      	public void func()
      	{
         	Console.WriteLine("Inside first_space");
      	}
   	}
}

namespace second_space
{
   	class efg
   	{
      	public void func()
      	{
         	Console.WriteLine("Inside second_space");
      	}
   	}
}

class TestClass
{
   	static void Main(string[] args)
   	{
      	abc fc = new abc();
      	efg sc = new efg();
      	fc.func();
      	sc.func();
      	Console.ReadKey();
   	}
}
