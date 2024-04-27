/*
C# 二进制文件的读写
C# 文件的输入与输出 C# 文件的输入与输出
BinaryReader 和 BinaryWriter 类用于二进制文件的读写。


BinaryReader 类
BinaryReader 类用于从文件读取二进制数据。一个 BinaryReader 对象通过向它的构造函数传递 FileStream 对象而被创建。
下表列出了 BinaryReader 类中一些常用的方法：
序号	方法 & 描述
1	public override void Close()						关闭 BinaryReader 对象和基础流。
2	public virtual int Read()							从基础流中读取字符，并把流的当前位置往前移。
3	public virtual bool ReadBoolean()					从当前流中读取一个布尔值，并把流的当前位置往前移一个字节。
4	public virtual byte ReadByte()						从当前流中读取下一个字节，并把流的当前位置往前移一个字节。
5	public virtual byte[] ReadBytes( int count )		从当前流中读取指定数目的字节到一个字节数组中，并把流的当前位置往前移指定数目的字节。
6	public virtual char ReadChar()						从当前流中读取下一个字节，并把流的当前位置按照所使用的编码和从流中读取的指定的字符往前移。
7	public virtual char[] ReadChars( int count )		从当前流中读取指定数目的字节，在一个字符数组中返回数组，并把流的当前位置按照所使用的编码和从流中读取的指定的字符往前移。
8	public virtual double ReadDouble()					从当前流中读取一个 8 字节浮点值，并把流的当前位置往前移八个字节。
9	public virtual int ReadInt32()						从当前流中读取一个 4 字节有符号整数，并把流的当前位置往前移四个字节。
10	public virtual string ReadString()					从当前流中读取一个字符串。字符串以长度作为前缀，同时编码为一个七位的整数。


BinaryWriter 类
BinaryWriter 类用于向文件写入二进制数据。一个 BinaryWriter 对象通过向它的构造函数传递 FileStream 对象而被创建。
下表列出了 BinaryWriter 类中一些常用的方法：
序号	方法 & 描述
1	public override void Close()									关闭 BinaryWriter 对象和基础流。
2	public virtual void Flush()										清理当前编写器的所有缓冲区，使得所有缓冲数据写入基础设备。
3	public virtual long Seek( int offset, SeekOrigin origin )		设置当前流内的位置。
4	public virtual void Write( bool value )							把一个单字节的布尔值写入到当前流中，0 表示 false，1 表示 true。
5	public virtual void Write( byte value )							把一个无符号字节写入到当前流中，并把流的位置往前移一个字节。
6	public virtual void Write( byte[] buffer )						把一个字节数组写入到基础流中。
7	public virtual void Write( char ch )							把一个 Unicode 字符写入到当前流中，并把流的当前位置按照所使用的编码和要写入到流中的指定的字符往前移。
8	public virtual void Write( char[] chars )						把一个字符数组写入到当前流中，并把流的当前位置按照所使用的编码和要写入到流中的指定的字符往前移。
9	public virtual void Write( double value )						把一个 8 字节浮点值写入到当前流中，并把流位置往前移八个字节。
10	public virtual void Write( int value )							把一个 4 字节有符号整数写入到当前流中，并把流位置往前移四个字节。
11	public virtual void Write( string value )						把一个以长度为前缀的字符串写入到 BinaryWriter 的当前编码的流中，并把流的当前位置按照所使用的编码和要写入到流中的指定的字符往前移。

*/

using System;
using System.IO;

namespace BinaryFileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw;
            BinaryReader br;
            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "I am happy";
            // 创建文件
            try
            {
                bw = new BinaryWriter(new FileStream("mydata", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }
            // 写入文件
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }

            bw.Close();
            // 读取文件
            try
            {
                br = new BinaryReader(new FileStream("mydata", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return;
            }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer data: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double data: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", b);
                s = br.ReadString();
                Console.WriteLine("String data: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            br.Close();
            Console.ReadKey();
        }
    }
}
















