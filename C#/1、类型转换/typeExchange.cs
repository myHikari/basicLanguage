/*
在 C# 中，类型转换是将一个数据类型的值转换为另一个数据类型的过程。
C# 中的类型转换可以分为两种：隐式类型转换和显式类型转换（也称为强制类型转换）。


隐式类型转换
隐式转换是指将一个较小范围的数据类型转换为较大范围的数据类型时，编译器会自动完成类型转换，这些转换是 C# 默认的以安全方式进行的转换, 不会导致数据丢失。

例如，从小的整数类型转换为大的整数类型，从派生类转换为基类。将一个 byte 类型的变量赋值给 int 类型的变量，编译器会自动将 byte 类型转换为 int 类型，不需要显示转换。
byte b = 10;
int i = b; // 隐式转换，不需要显式转换

将一个整数赋值给一个长整数，或者将一个浮点数赋值给一个双精度浮点数，这种转换不会导致数据丢失：
int intValue = 42;
long longValue = intValue; // 隐式转换，从 int 到 long



显式转换
显式类型转换，即强制类型转换。
显式转换是指将一个较大范围的数据类型转换为较小范围的数据类型时，或者将一个对象类型转换为另一个对象类型时，需要使用强制类型转换符号进行显示转换，强制转换会造成数据丢失。

例如，将一个 int 类型的变量赋值给 byte 类型的变量，需要显示转换。
int i = 10;
byte b = (byte)i; // 显式转换，需要使用强制类型转换符号

强制转换为整数类型：
double doubleValue = 3.14;
int intValue = (int)doubleValue; // 强制从 double 到 int，数据可能损失小数部分

强制转换为浮点数类型：
int intValue = 42;
float floatValue = (float)intValue; // 强制从 int 到 float，数据可能损失精度

强制转换为字符串类型：
int intValue = 123;
string stringValue = intValue.ToString(); // 将 int 转换为字符串
*/

using System;

namespace TypeConversionApplication
{
    class ExplicitConversion
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;

            // 强制转换 double 为 int
            i = (int)d;
            Console.WriteLine(i);
            Console.ReadKey();
           
        }
    }
}




































