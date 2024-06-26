/*
循环类型
C# 提供了以下几种循环类型。点
循环类型	描述
while 循环	当给定条件为真时，重复语句或语句组。它会在执行循环主体之前测试条件。
C# 中 while 循环的语法：
while(condition)
{
   statement(s);
}
在这里，statement(s) 可以是一个单独的语句，也可以是几个语句组成的代码块。condition 可以是任意的表达式，当为任意非零值时都为真。当条件为真时执行循环。
当条件为假时，程序流将继续执行紧接着循环的下一条语句。


for/foreach 循环	多次执行一个语句序列，简化管理循环变量的代码。
一个 for 循环是一个允许您编写一个执行特定次数的循环的重复控制结构。
C# 中 for 循环的语法：
for ( init; condition; increment )
{
   statement(s);
}

下面是 for 循环的控制流：
    init 会首先被执行，且只会执行一次。这一步允许您声明并初始化任何循环控制变量。您也可以不在这里写任何语句，只要有一个分号出现即可。
    	接下来，会判断 condition。如果为真，则执行循环主体。如果为假，则不执行循环主体，且控制流会跳转到紧接着 for 循环的下一条语句。
    	在执行完 for 循环主体后，控制流会跳回上面的 increment 语句。该语句允许您更新循环控制变量。该语句可以留空，只要在条件后有一个分号出现即可。
    	条件再次被判断。如果为真，则执行循环，这个过程会不断重复（循环主体，然后增加步值，再然后重新判断条件）。在条件变为假时，for 循环终止。

foreach
C# 也支持 foreach 循环，使用 foreach 可以迭代数组或者一个集合对象。
C# 的 foreach 循环可以用来遍历集合类型，例如数组、列表、字典等。它是一个简化版的 for 循环，使得代码更加简洁易读。
以下是 foreach 循环的语法：
foreach (var item in collection)
{
    // 循环
}
collection 是要遍历的集合，item 是当前遍历到的元素。
以下实例有三个部分：
    	通过 foreach 循环输出整型数组中的元素。
    	通过 for 循环输出整型数组中的元素。
    foreach 循环设置数组元素的计算器。


do...while 循环	除了它是在循环主体结尾测试条件外，其他与 while 语句类似。
不像 for 和 while 循环，它们是在循环头部测试循环条件。do...while 循环是在循环的尾部检查它的条件。
do...while 循环与 while 循环类似，但是 do...while 循环会确保至少执行一次循环。
C# 中 do...while 循环的语法：
do
{
   statement(s);

}while( condition );

请注意，条件表达式出现在循环的尾部，所以循环中的 statement(s) 会在条件被测试之前至少执行一次。
如果条件为真，控制流会跳转回上面的 do，然后重新执行循环中的 statement(s)。这个过程会不断重复，直到给定条件变为假为止。



嵌套循环	您可以在 while、for 或 do..while 循环内使用一个或多个循环。

循环控制语句
循环控制语句更改执行的正常序列。当执行离开一个范围时，所有在该范围中创建的自动对象都会被销毁。

C# 提供了下列的控制语句。
控制语句	描述
break 语句	终止 loop 或 switch 语句，程序流将继续执行紧接着 loop 或 switch 的下一条语句。
continue 语句	跳过本轮循环，开始下一轮循环。

*/


using System;
using System.Collections.Generic;

namespace Loops
{
   
    class Program
    {
    	static void Main() {
    		test1();
    		test2();
    		test3();
    		test4();
    		test5();
    	}
    	
    	// while
        static void test1()
        {
            /* 局部变量定义 */
            int a = 10;

            /* while 循环执行 */
            while (a < 20)
            {
                Console.WriteLine("a 的值： {0}", a);
                a++;
            }
            Console.ReadLine();
        }
        
        // for
        static void test2()
        {
            /* for 循环执行 */
            for (int a = 10; a < 20; a = a + 1)
            {
                Console.WriteLine("a 的值： {0}", a);
            }
            Console.ReadLine();
        }
        
        // foreach
        static void test3()
    	{
        	int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
        	foreach (int element in fibarray)
        	{
            	System.Console.WriteLine(element);
        	}
        	System.Console.WriteLine();


        	// 类似 foreach 循环
        	for (int i = 0; i < fibarray.Length; i++)
        	{
            	System.Console.WriteLine(fibarray[i]);
        	}
        	System.Console.WriteLine();


        	// 设置集合中元素的计算器
        	int count = 0;
        	foreach (int element in fibarray)
        	{
            	count += 1;
            	System.Console.WriteLine("Element #{0}: {1}", count, element);
        	}
        	System.Console.WriteLine("Number of elements in the array: {0}", count);
    	}
    	
    	// foreach
    	static void test4()
    	{
        	// 创建一个字符串列表
        	List<string> myStrings = new List<string>();

        	// 向列表添加一些字符串元素
        	myStrings.Add("Google");
        	myStrings.Add("Runoob");
        	myStrings.Add("Taobao");

        	// 使用 foreach 循环遍历列表中的元素
        	foreach (string s in myStrings)
        	{
            	Console.WriteLine(s);
        	}

        	// 等待用户按下任意键后退出程序
        	Console.ReadKey();
    	}
    	
    	// do .. while
    	static void test5()
        {
            /* 局部变量定义 */
            int a = 10;

            /* do 循环执行 */
            do
            {
               Console.WriteLine("a 的值： {0}", a);
                a = a + 1;
            } while (a < 20);

            Console.ReadLine();
        }
    }
}












