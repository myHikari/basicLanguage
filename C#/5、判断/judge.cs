/*
if 语句
一个 if 语句 由一个布尔表达式后跟一个或多个语句组成。

C# 中 if 语句的语法：
if(boolean_expression)
{
   // 如果布尔表达式为真将执行的语句
}


if...else 语句
一个 if 语句 后可跟一个可选的 else 语句，else 语句在布尔表达式为假时执行。

C# 中 if...else 语句的语法：
if(boolean_expression)
{
   // 如果布尔表达式为真将执行的语句 
}
else
{
  // 如果布尔表达式为假将执行的语句 
}


if...else if...else 语句
一个 if 语句后可跟一个可选的 else if...else 语句，这可用于测试多种条件。
当使用 if...else if...else 语句时，以下几点需要注意：
    一个 if 后可跟零个或一个 else，它必须在任何一个 else if 之后。
    一个 if 后可跟零个或多个 else if，它们必须在 else 之前。
    一旦某个 else if 匹配成功，其他的 else if 或 else 将不会被测试。

if...else if...else 语句的语法：
if(boolean_expression 1)
{
   // 当布尔表达式 1 为真时执行 
}
else if( boolean_expression 2)
{
   // 当布尔表达式 2 为真时执行
}
else if( boolean_expression 3)
{
   // 当布尔表达式 3 为真时执行 
}
else 
{
   // 当上面条件都不为真时执行 
}


switch 语句
一个 switch 语句允许测试一个变量等于多个值时的情况。每个值称为一个 case，且被测试的变量会对每个 switch case 进行检查。
语法
C# 中 switch 语句的语法：
switch(expression){
    case constant-expression  :
       statement(s);
       break; 
    case constant-expression  :
       statement(s);
       break; 
  
    // 您可以有任意数量的 case 语句 
    default : // 可选的 
       statement(s);
       break; 
}

switch 语句必须遵循下面的规则：
    switch 语句中的 expression 必须是一个整型或枚举类型，或者是一个 class 类型，其中 class 有一个单一的转换函数将其转换为整型或枚举类型。
    在一个 switch 中可以有任意数量的 case 语句。每个 case 后跟一个要比较的值和一个冒号。
    
    case 的 constant-expression 必须与 switch 中的变量具有相同的数据类型，且必须是一个常量。
    当被测试的变量等于 case 中的常量时，case 后跟的语句将被执行，直到遇到 break 语句为止。
    当遇到 break 语句时，switch 终止，控制流将跳转到 switch 语句后的下一行。
    不是每一个 case 都需要包含 break。如果 case 语句为空，则可以不包含 break，控制流将会 继续 后续的 case，直到遇到 break 为止。
    
    C# 不允许从一个 case 部分继续执行到下一个 case 部分。如果 case 语句中有已经执行，则必须包含 break 或其他跳转语句。
    一个 switch 语句可以有一个可选的 default 语句，在 switch 的结尾。default 语句用于在上面所有 case 都不为 true 时执行的一个任务。default 也需要包含 break 语句，这是一个良好的习惯。
    
    C# 不支持从一个 case 标签显式贯穿到另一个 case 标签。如果要使 C# 支持从一个 case 标签显式贯穿到另一个 case 标签，可以使用 goto 一个 switch-case 或 goto default。


? : 运算符
我们已经在前面的章节中讲解了 条件运算符 ? :，可以用来替代 if...else 语句。它的一般形式如下：
Exp1 ? Exp2 : Exp3;
其中，Exp1、Exp2 和 Exp3 是表达式。请注意，冒号的使用和位置。
? 表达式的值是由 Exp1 决定的。
如果 Exp1 为真，则计算 Exp2 的值，结果即为整个 ? 表达式的值。
如果 Exp1 为假，则计算 Exp3 的值，结果即为整个 ? 表达式的值。
*/

using System;

namespace DecisionMaking
{
   
    class Program
    {
    	
    	static void Main(string[] args) {
    		test1();
    		test2();
    		test3();
    		test4();
    	}
    	
    	
    	// if .. 
        static void test1()
        {
            /* 局部变量定义 */
            int a = 10;

            /* 使用 if 语句检查布尔条件 */
            if (a < 20)
            {
                /* 如果条件为真，则输出下面的语句 */
                Console.WriteLine("a 小于 20");
            }
            Console.WriteLine("a 的值是 {0}", a);
            Console.ReadLine();
        }
        
        // if .. else ..
        static void test2()
        {
            /* 局部变量定义 */
            int a = 10;

            /* 使用 if 语句检查布尔条件 */
            if (a < 20)
            {
                /* 如果条件为真，则输出下面的语句 */
                Console.WriteLine("a 小于 20");
            }
            Console.WriteLine("a 的值是 {0}", a);
            Console.ReadLine();
        }
        
        // if .. else if .. else ..
        static void test3()
        {

            /* 局部变量定义 */
            int a = 100;

            /* 检查布尔条件 */
            if (a == 10)
            {
                /* 如果 if 条件为真，则输出下面的语句 */
                Console.WriteLine("a 的值是 10");
            }
            else if (a == 20)
            {
                /* 如果 else if 条件为真，则输出下面的语句 */
                Console.WriteLine("a 的值是 20");
            }
            else if (a == 30)
            {
                /* 如果 else if 条件为真，则输出下面的语句 */
                Console.WriteLine("a 的值是 30");
            }
            else
            {
                /* 如果上面条件都不为真，则输出下面的语句 */
                Console.WriteLine("没有匹配的值");
            }
            Console.WriteLine("a 的准确值是 {0}", a);
            Console.ReadLine();
        }
        
        
        // switch
        static void test4()
    	{
      		int day = 4;
      		switch (day)
      		{
        		case 1:
          			Console.WriteLine("Monday");
          			break;
        		case 2:
          			Console.WriteLine("Tuesday");
          			break;
        		case 3:
          			Console.WriteLine("Wednesday");
          			break;
        		case 4:
          			Console.WriteLine("Thursday");
          			break;
        		case 5:
          			Console.WriteLine("Friday");
          			break;
        		case 6:
          			Console.WriteLine("Saturday");
          			break;
        		case 7:
          			Console.WriteLine("Sunday");
          			break;
      		}    
    	}
        
    }
}







