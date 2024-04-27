/*
C# 排序列表（SortedList）
SortedList 类代表了一系列按照键来排序的键/值对，这些键值对可以通过键和索引来访问。
排序列表是数组和哈希表的组合。它包含一个可使用键或索引访问各项的列表。如果您使用索引访问各项，则它是一个动态数组（ArrayList），如果您使用键访问各项，则它是一个哈希表（Hashtable）。集合中的各项总是按键值排序。


SortedList 类的方法和属性
下表列出了 SortedList 类的一些常用的 属性：
属性				描述
Capacity 		获取或设置 SortedList 的容量。
Count			获取 SortedList 中的元素个数。
IsFixedSize		获取一个值，表示 SortedList 是否具有固定大小。
IsReadOnly		获取一个值，表示 SortedList 是否只读。
Item			获取或设置与 SortedList 中指定的键相关的值。
Keys			获取 SortedList 中的键。
Values			获取 SortedList 中的值。

下表列出了 SortedList 类的一些常用的 方法：
序号																方法名 & 描述
1	public virtual void Add( object key, object value );		向 SortedList 添加一个带有指定的键和值的元素。
2	public virtual void Clear();								从 SortedList 中移除所有的元素。
3	public virtual bool ContainsKey( object key );				判断 SortedList 是否包含指定的键。
4	public virtual bool ContainsValue( object value );			判断 SortedList 是否包含指定的值。
5	public virtual object GetByIndex( int index );				获取 SortedList 的指定索引处的值。
6	public virtual object GetKey( int index );					获取 SortedList 的指定索引处的键。
7	public virtual IList GetKeyList();							获取 SortedList 中的键。
8	public virtual IList GetValueList();						获取 SortedList 中的值。
9	public virtual int IndexOfKey( object key );				返回 SortedList 中的指定键的索引，索引从零开始。
10	public virtual int IndexOfValue( object value );			返回 SortedList 中的指定值第一次出现的索引，索引从零开始。
11	public virtual void Remove( object key );					从 SortedList 中移除带有指定的键的元素。
12	public virtual void RemoveAt( int index );					移除 SortedList 的指定索引处的元素。
13	public virtual void TrimToSize();							设置容量为 SortedList 中元素的实际个数。
*/

using System;
using System.Collections;

namespace CollectionsApplication
{
   class Program
   {
      static void Main(string[] args)
      {
         SortedList sl = new SortedList();

         sl.Add("001", "Zara Ali");
         sl.Add("002", "Abida Rehman");
         sl.Add("003", "Joe Holzner");
         sl.Add("004", "Mausam Benazir Nur");
         sl.Add("005", "M. Amlan");
         sl.Add("006", "M. Arif");
         sl.Add("007", "Ritesh Saikia");

         if (sl.ContainsValue("Nuha Ali"))
         {
            Console.WriteLine("This student name is already in the list");
         }
         else
         {
            sl.Add("008", "Nuha Ali");
         }

         // 获取键的集合
         ICollection key = sl.Keys;

         foreach (string k in key)
         {
            Console.WriteLine(k + ": " + sl[k]);
         }
      }
   }
}



