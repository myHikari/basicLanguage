/*
C# 动态数组（ArrayList）
动态数组（ArrayList）代表了可被单独索引的对象的有序集合。它基本上可以替代一个数组。
但是，与数组不同的是，您可以使用索引在指定的位置添加和移除项目，动态数组会自动重新调整它的大小。
它也允许在列表中进行动态内存分配、增加、搜索、排序各项。

ArrayList 类的方法和属性
下表列出了 ArrayList 类的一些常用的 属性：
属性				描述
Capacity 		获取或设置 ArrayList 可以包含的元素个数。
Count			获取 ArrayList 中实际包含的元素个数。
IsFixedSize		获取一个值，表示 ArrayList 是否具有固定大小。
IsReadOnly		获取一个值，表示 ArrayList 是否只读。
IsSynchronized	获取一个值，表示访问 ArrayList 是否同步（线程安全）。
Item[Int32]		获取或设置指定索引处的元素。
SyncRoot		获取一个对象用于同步访问 ArrayList。

下表列出了 ArrayList 类的一些常用的 方法：
序号																	方法名 & 描述
1	public virtual int Add( object value );							在 ArrayList 的末尾添加一个对象。
2	public virtual void AddRange( ICollection c );					在 ArrayList 的末尾添加 ICollection 的元素。
3	public virtual void Clear();									从 ArrayList 中移除所有的元素。
4	public virtual bool Contains( object item );					判断某个元素是否在 ArrayList 中。
5	public virtual ArrayList GetRange( int index, int count );		返回一个 ArrayList，表示源 ArrayList 中元素的子集。
6	public virtual int IndexOf(object);								返回某个值在 ArrayList 中第一次出现的索引，索引从零开始。
7	public virtual void Insert( int index, object value );			在 ArrayList 的指定索引处，插入一个元素。
8	public virtual void InsertRange( int index, ICollection c );	在 ArrayList 的指定索引处，插入某个集合的元素。
9	public virtual void Remove( object obj );						从 ArrayList 中移除第一次出现的指定对象。
10	public virtual void RemoveAt( int index );						移除 ArrayList 的指定索引处的元素。
11	public virtual void RemoveRange( int index, int count );		从 ArrayList 中移除某个范围的元素。
12	public virtual void Reverse();									逆转 ArrayList 中元素的顺序。
13	public virtual void SetRange( int index, ICollection c );		复制某个集合的元素到 ArrayList 中某个范围的元素上。
14	public virtual void Sort();										对 ArrayList 中的元素进行排序。
15	public virtual void TrimToSize();								设置容量为 ArrayList 中元素的实际个数。

*/

using System;
using System.Collections;

namespace CollectionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);
           
            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);
                     
            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}


