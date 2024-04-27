/*
C# 命名空间（Namespace）
命名空间的设计目的是提供一种让一组名称与其他名称分隔开的方式。在一个命名空间中声明的类的名称与另一个命名空间中声明的相同的类的名称不冲突。
我们举一个计算机系统中的例子，一个文件夹(目录)中可以包含多个文件夹，每个文件夹中不能有相同的文件名，但不同文件夹中的文件可以重名。

定义命名空间
命名空间的定义是以关键字 namespace 开始，后跟命名空间的名称，如下所示：
namespace namespace_name
{
   // 代码声明
}

为了调用支持命名空间版本的函数或变量，会把命名空间的名称置于前面，如下所示：
namespace_name.item_name;



嵌套命名空间
命名空间可以被嵌套，即您可以在一个命名空间内定义另一个命名空间，如下所示：
namespace namespace_name1 
{
   // 代码声明
   namespace namespace_name2 
   {
     // 代码声明
   }
}

您可以使用点（.）运算符访问嵌套的命名空间的成员

*/

using System;
// using SomeNameSpace;
using SomeNameSpace.Nested;

namespace first_space
{
   class namespace_cl
   {
      public void func()
      {
         Console.WriteLine("Inside first_space");
      }
   }
}
namespace second_space
{
   class namespace_cl
   {
      public void func()
      {
         Console.WriteLine("Inside second_space");
      }
   }
}

namespace SomeNameSpace
{
    // 内嵌命名空间
    namespace Nested  
    {
        public class NestedNameSpaceClass
        {
            public static void SayHello()
            {
                Console.WriteLine("In Nested");
            }
        }
    }
}

class TestClass
{
	
   	static void Main(string[] args) {
   		singleNameTester();
   		someNameTester();
   	
   	}
   	
   	static void singleNameTester()
   	{
      	first_space.namespace_cl fc = new first_space.namespace_cl();
      	second_space.namespace_cl sc = new second_space.namespace_cl();
      	fc.func();
      	sc.func();
      	Console.ReadKey();
   	}
   
   	static void someNameTester()
	{
		Console.WriteLine("In SomeNameSpace");
		// SomeNameSpace.Nested.NestedNameSpaceClass.SayHello();
		// 由于在文件开头已经声明使用该空间：using SomeNameSpace.Nested; 可用以下句式
		NestedNameSpaceClass.SayHello();
	}
}




