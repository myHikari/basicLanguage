/*
C# Windows 文件系统的操作
C# 文件的输入与输出 C# 文件的输入与输出
C# 允许您使用各种目录和文件相关的类来操作目录和文件，比如 DirectoryInfo 类和 FileInfo 类。


DirectoryInfo 类
DirectoryInfo 类派生自 FileSystemInfo 类。它提供了各种用于创建、移动、浏览目录和子目录的方法。该类不能被继承。
下表列出了 DirectoryInfo 类中一些常用的属性：
序号	属性 & 描述
1	Attributes				获取当前文件或目录的属性。
2	CreationTime			获取当前文件或目录的创建时间。
3	Exists					获取一个表示目录是否存在的布尔值。
4	Extension				获取表示文件存在的字符串。
5	FullName				获取目录或文件的完整路径。
6	LastAccessTime			获取当前文件或目录最后被访问的时间。
7	Name					获取该 DirectoryInfo 实例的名称。

下表列出了 DirectoryInfo 类中一些常用的方法：
序号	方法 & 描述
1	public void Create()													创建一个目录。
2	public DirectoryInfo CreateSubdirectory( string path )					在指定的路径上创建子目录。指定的路径可以是相对于 DirectoryInfo 类的实例的路径。
3	public override void Delete()											如果为空的，则删除该 DirectoryInfo。
4	public DirectoryInfo[] GetDirectories()									返回当前目录的子目录。
5	public FileInfo[] GetFiles()											从当前目录返回文件列表。



FileInfo 类
FileInfo 类派生自 FileSystemInfo 类。它提供了用于创建、复制、删除、移动、打开文件的属性和方法，且有助于 FileStream 对象的创建。该类不能被继承。
下表列出了 FileInfo 类中一些常用的属性：
序号	属性 & 描述
1	Attributes				获取当前文件的属性。
2	CreationTime			获取当前文件的创建时间。
3	Directory				获取文件所属目录的一个实例。
4	Exists					获取一个表示文件是否存在的布尔值。
5	Extension				获取表示文件存在的字符串。
6	FullName				获取文件的完整路径。
7	LastAccessTime			获取当前文件最后被访问的时间。
8	LastWriteTime			获取文件最后被写入的时间。
9	Length					获取当前文件的大小，以字节为单位。
10	Name					获取文件的名称。

下表列出了 FileInfo 类中一些常用的方法：
序号	方法 & 描述
1	public StreamWriter AppendText()												创建一个 StreamWriter，追加文本到由 FileInfo 的实例表示的文件中。
2	public FileStream Create()														创建一个文件。
3	public override void Delete()													永久删除一个文件。
4	public void MoveTo( string destFileName )										移动一个指定的文件到一个新的位置，提供选项来指定新的文件名。
5	public FileStream Open( FileMode mode )											以指定的模式打开一个文件。
6	public FileStream Open( FileMode mode, FileAccess access )						以指定的模式，使用 read、write 或 read/write 访问，来打开一个文件。
7	public FileStream Open( FileMode mode, FileAccess access, FileShare share )		以指定的模式，使用 read、write 或 read/write 访问，以及指定的分享选项，来打开一个文件。
8	public FileStream OpenRead()													创建一个只读的 FileStream。
9	public FileStream OpenWrite()													创建一个只写的 FileStream。

*/



using System;
using System.IO;

namespace WindowsFileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个 DirectoryInfo 对象
            DirectoryInfo mydir = new DirectoryInfo(@"/home/goes");

            // 获取目录中的文件以及它们的名称和大小
            FileInfo [] f = mydir.GetFiles();
            foreach (FileInfo file in f)
            {
                Console.WriteLine("File Name: {0} Size: {1}", file.Name, file.Length);
            }
            Console.ReadKey();
        }
    }
}













