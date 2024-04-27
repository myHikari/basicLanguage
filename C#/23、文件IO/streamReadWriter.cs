/*
C# 文本文件的读写
C# 文件的输入与输出 C# 文件的输入与输出
StreamReader 和 StreamWriter 类用于文本文件的数据读写。这些类从抽象基类 Stream 继承，Stream 支持文件流的字节读写。

StreamReader 类
StreamReader 类继承自抽象基类 TextReader，表示阅读器读取一系列字符。
下表列出了 StreamReader 类中一些常用的方法：
序号	方法 & 描述
1	public override void Close()	关闭 StreamReader 对象和基础流，并释放任何与读者相关的系统资源。
2	public override int Peek()		返回下一个可用的字符，但不使用它。
3	public override int Read()		从输入流中读取下一个字符，并把字符位置往前移一个字符。


StreamWriter 类
StreamWriter 类继承自抽象类 TextWriter，表示编写器写入一系列字符。
下表列出了 StreamWriter 类中一些常用的方法：
序号	方法 & 描述
1	public override void Close()				关闭当前的 StreamWriter 对象和基础流。
2	public override void Flush()				清理当前编写器的所有缓冲区，使得所有缓冲数据写入基础流。
3	public virtual void Write(bool value)		把一个布尔值的文本表示形式写入到文本字符串或流。（继承自 TextWriter。）
4	public override void Write(char value)		把一个字符写入到流。
5	public virtual void Write(decimal value)	把一个十进制值的文本表示形式写入到文本字符串或流。
6	public virtual void Write(double value)		把一个 8 字节浮点值的文本表示形式写入到文本字符串或流。
7	public virtual void Write(int value)		把一个 4 字节有符号整数的文本表示形式写入到文本字符串或流。
8	public override void Write(string value)	把一个字符串写入到流。
9	public virtual void WriteLine()				把行结束符写入到文本字符串或流。

*/


using System;
using System.IO;
using System.Text;

namespace FileApplication
{
    class Program
    {
        static void Main(string[] args) {
        	reader();
        	writer();
        }
        
        static void reader()
        {
            try
            {
                // 创建一个 StreamReader 的实例来读取文件 
                // using 语句也能关闭 StreamReader
                using (StreamReader sr = new StreamReader("Jamaica.txt", Encoding.UTF8))
                {
                    string line;
                   
                    // 从文件读取并显示行，直到文件的末尾 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // 向用户显示出错消息
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
        
        static void writer()
        {

            string[] names = new string[] {"Zara Ali", "Nuha Ali"};
            using (StreamWriter sw = new StreamWriter("names.txt"))
            {
                foreach (string s in names)
                {
                    sw.WriteLine(s);

                }
            }

            // 从文件中读取并显示每行
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }
}











