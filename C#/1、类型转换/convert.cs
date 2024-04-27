/*
C# 类型转换方法
C# 提供了下列内置的类型转换方法：
序号	方法 & 描述
1	ToBoolean
如果可能的话，把类型转换为布尔型。

2	ToByte
把类型转换为字节类型。

3	ToChar
如果可能的话，把类型转换为单个 Unicode 字符类型。

4	ToDateTime
把类型（整数或字符串类型）转换为 日期-时间 结构。

5	ToDecimal
把浮点型或整数类型转换为十进制类型。

6	ToDouble
把类型转换为双精度浮点型。

7	ToInt16
把类型转换为 16 位整数类型。

8	ToInt32
把类型转换为 32 位整数类型。

9	ToInt64
把类型转换为 64 位整数类型。

10	ToSbyte
把类型转换为有符号字节类型。

11	ToSingle
把类型转换为小浮点数类型。

12	ToString
把类型转换为字符串类型。

13	ToType
把类型转换为指定类型。

14	ToUInt16
把类型转换为 16 位无符号整数类型。

15	ToUInt32
把类型转换为 32 位无符号整数类型。

16	ToUInt64
把类型转换为 64 位无符号整数类型。



在进行类型转换时需要注意以下几点：
    隐式转换只能将较小范围的数据类型转换为较大范围的数据类型，不能将较大范围的数据类型转换为较小范围的数据类型；
    显式转换可能会导致数据丢失或精度降低，需要进行数据类型的兼容性检查；
    对于对象类型的转换，需要进行类型转换的兼容性检查和类型转换的安全性检查。
*/

using System;
namespace TypeConversionApplication
{
    class StringConversion
    {
        static void Main(string[] args)
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();
           
        }
    }
}
