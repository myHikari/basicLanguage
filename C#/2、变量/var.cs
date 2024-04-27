/*
C# 变量
一个变量只不过是一个供程序操作的存储区的名字。在 C# 中，每个变量都有一个特定的类型，类型决定了变量的内存大小和布局。范围内的值可以存储在内存中，可以对变量进行一系列操作。

我们已经讨论了各种数据类型。C# 中提供的基本的值类型大致可以分为以下几类：
类型	举例
整数类型	sbyte、byte、short、ushort、int、uint、long、ulong 和 char
浮点型	float 和 double
十进制类型	decimal
布尔类型	true 或 false 值，指定的值
空类型	可为空值的数据类型


C# 允许定义其他值类型的变量，比如 enum，也允许定义引用类型变量，比如 class。这些我们将在以后的章节中进行讨论。在本章节中，我们只研究基本变量类型。
C# 中的变量定义
C# 中变量定义的语法：
<data_type> <variable_list>;

在这里，data_type 必须是一个有效的 C# 数据类型，可以是 char、int、float、double 或其他用户自定义的数据类型。variable_list 可以由一个或多个用逗号分隔的标识符名称组成。

C# 中的变量初始化
变量通过在等号后跟一个常量表达式进行初始化（赋值）。初始化的一般形式为：
variable_name = value;

变量可以在声明时被初始化（指定一个初始值）。初始化由一个等号后跟一个常量表达式组成，如下所示：
<data_type> <variable_name> = value;


*/
using System;
namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            short a;
            int b ;
            double c;

            /* 实际初始化 */
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadLine();
        }
    }
}




/*
接受来自用户的值
System 命名空间中的 Console 类提供了一个函数 ReadLine()，用于接收来自用户的输入，并把它存储到一个变量中。
例如：
int num;
num = Convert.ToInt32(Console.ReadLine());


函数 Convert.ToInt32() 把用户输入的数据转换为 int 数据类型，因为 Console.ReadLine() 只接受字符串格式的数据。
C# 中的 Lvalues 和 Rvalues
C# 中的两种表达式：
    lvalue：lvalue 表达式可以出现在赋值语句的左边或右边。
    rvalue：rvalue 表达式可以出现在赋值语句的右边，不能出现在赋值语句的左边。

变量是 lvalue 的，所以可以出现在赋值语句的左边。数值是 rvalue 的，因此不能被赋值，不能出现在赋值语句的左边。下面是一个有效的语句：
int g = 20;
下面是一个无效的语句，会产生编译时错误：
10 = 20;

*/














