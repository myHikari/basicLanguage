/*
C# 哈希表（Hashtable）
Hashtable 类代表了一系列基于键的哈希代码组织起来的键/值对。它使用键来访问集合中的元素。
当您使用键访问元素时，则使用哈希表，而且您可以识别一个有用的键值。哈希表中的每一项都有一个键/值对。键用于访问集合中的项目。

Hashtable 类的方法和属性
下表列出了 Hashtable 类的一些常用的 属性：
属性			描述
Count		获取 Hashtable 中包含的键值对个数。
IsFixedSize	获取一个值，表示 Hashtable 是否具有固定大小。
IsReadOnly	获取一个值，表示 Hashtable 是否只读。
Item		获取或设置与指定的键相关的值。
Keys		获取一个 ICollection，包含 Hashtable 中的键。
Values		获取一个 ICollection，包含 Hashtable 中的值。

下表列出了 Hashtable 类的一些常用的 方法：
序号																方法名 & 描述
1	public virtual void Add( object key, object value );		向 Hashtable 添加一个带有指定的键和值的元素。
2	public virtual void Clear();								从 Hashtable 中移除所有的元素。
3	public virtual bool ContainsKey( object key );				判断 Hashtable 是否包含指定的键。
4	public virtual bool ContainsValue( object value );			判断 Hashtable 是否包含指定的值。
5	public virtual void Remove( object key );					从 Hashtable 中移除带有指定的键的元素。
*/
using System;
using System.Collections;

namespace CollectionsApplication
{
   class Program
   {
      static void Main(string[] args)
      {
         Hashtable ht = new Hashtable();


         ht.Add("001", "Zara Ali");
         ht.Add("002", "Abida Rehman");
         ht.Add("003", "Joe Holzner");
         ht.Add("004", "Mausam Benazir Nur");
         ht.Add("005", "M. Amlan");
         ht.Add("006", "M. Arif");
         ht.Add("007", "Ritesh Saikia");

         if (ht.ContainsValue("Nuha Ali"))
         {
            Console.WriteLine("This student name is already in the list");
         }
         else
         {
            ht.Add("008", "Nuha Ali");
         }
         // 获取键的集合
         ICollection key = ht.Keys;

         foreach (string k in key)
         {
            Console.WriteLine(k + ": " + ht[k]);
         }
         Console.ReadKey();
      }
   }
}


