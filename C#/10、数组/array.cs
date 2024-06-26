/*
C# 数组（Array）
数组是一个存储相同类型元素的固定大小的顺序集合。数组是用来存储数据的集合，通常认为数组是一个同一类型变量的集合。
声明数组变量并不是声明 number0、number1、...、number99 一个个单独的变量，而是声明一个就像 numbers 这样的变量，然后使用 numbers[0]、numbers[1]、...、numbers[99] 来表示一个个单独的变量。数组中某个指定的元素是通过索引来访问的。
所有的数组都是由连续的内存位置组成的。最低的地址对应第一个元素，最高的地址对应最后一个元素。

C# 中的数组
声明数组
在 C# 中声明一个数组，您可以使用下面的语法：
datatype[] arrayName;
其中，
    datatype 用于指定被存储在数组中的元素的类型。
    [ ] 指定数组的秩（维度）。秩指定数组的大小。
    arrayName 指定数组的名称。

例如：
double[] balance;

初始化数组
声明一个数组不会在内存中初始化数组。当初始化数组变量时，您可以赋值给数组。
数组是一个引用类型，所以您需要使用 new 关键字来创建数组的实例。
例如：
double[] balance = new double[10];

赋值给数组
您可以通过使用索引号赋值给一个单独的数组元素
比如：
double[] balance = new double[10];
balance[0] = 4500.0;

您可以在声明数组的同时给数组赋值
比如：
double[] balance = { 2340.0, 4523.69, 3421.0};

您也可以创建并初始化一个数组
比如：
int [] marks = new int[5]  { 99,  98, 92, 97, 95};

在上述情况下，你也可以省略数组的大小
比如：
int [] marks = new int[]  { 99,  98, 92, 97, 95};

您也可以赋值一个数组变量到另一个目标数组变量中。在这种情况下，目标和源会指向相同的内存位置：
int [] marks = new int[]  { 99,  98, 92, 97, 95};
int[] score = marks;

当您创建一个数组时，C# 编译器会根据数组类型隐式初始化每个数组元素为一个默认值。例如，int 数组的所有元素都会被初始化为 0。

访问数组元素
元素是通过带索引的数组名称来访问的。这是通过把元素的索引放置在数组名称后的方括号中来实现的。例如：
double salary = balance[9];


*/


using System;
namespace ArrayApplication
{
   class MyArray
   {
      static void Main(string[] args) {
      		test1();
      		test2();
      		test3();
      		test4();
      		test5();
      		test6();
      		test7();
      }
      
      
      static void test1()
      {
         int []  n = new int[10]; /* n 是一个带有 10 个整数的数组 */
         int i,j;


         /* 初始化数组 n 中的元素 */        
         for ( i = 0; i < 10; i++ )
         {
            n[ i ] = i + 100;
         }

         /* 输出每个数组元素的值 */
         for (j = 0; j < 10; j++ )
         {
            Console.WriteLine("Element[{0}] = {1}", j, n[j]);
         }
         Console.ReadKey();
      }
      
      static void test2()
      {
         int []  n = new int[10]; /* n 是一个带有 10 个整数的数组 */


         /* 初始化数组 n 中的元素 */        
         for ( int i = 0; i < 10; i++ )
         {
            n[i] = i + 100;
         }

         /* 输出每个数组元素的值 */
         foreach (int j in n )
         {
            int i = j-100;
            Console.WriteLine("Element[{0}] = {1}", i, j);
         }
         Console.ReadKey();
      }
      

/*


C# 多维数组
C# 数组 C# 数组
C# 支持多维数组。多维数组又称为矩形数组。
您可以声明一个 string 变量的二维数组，如下：
string [,] names;
或者，您可以声明一个 int 变量的三维数组，如下：
int [ , , ] m;

二维数组
多维数组最简单的形式是二维数组。一个二维数组，在本质上，是一个一维数组的列表。
一个二维数组可以被认为是一个带有 x 行和 y 列的表格。下面是一个二维数组，包含 3 行和 4 列：
C# 中的二维数组
因此，数组中的每个元素是使用形式为 a[ i , j ] 的元素名称来标识的，其中 a 是数组名称，i 和 j 是唯一标识 a 中每个元素的下标。
初始化二维数组
多维数组可以通过在括号内为每行指定值来进行初始化。下面是一个带有 3 行 4 列的数组。

int [,] a = new int [3,4] {
 {0, 1, 2, 3} ,   //  初始化索引号为 0 的行 
 {4, 5, 6, 7} ,   //  初始化索引号为 1 的行 
 {8, 9, 10, 11}   //  初始化索引号为 2 的行 
};

访问二维数组元素
二维数组中的元素是通过使用下标（即数组的行索引和列索引）来访问的。例如：
int val = a[2,3];
*/
      static void test3()
      {
            /* 一个带有 5 行 2 列的数组 */
            int[,] a = new int[5, 2] {{0,0}, {1,2}, {2,4}, {3,6}, {4,8} };

            int i, j;

            /* 输出数组中每个元素的值 */
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i,j]);
                }
            }
           Console.ReadKey();
      }
      
/*
交错数组
C# 数组 C# 数组
交错数组是数组的数组。
交错数组是一维数组。
您可以声明一个带有 int 值的交错数组 scores，如下所示：
int [][] scores;

声明一个数组不会在内存中创建数组。创建上面的数组：
int[][] scores = new int[5][];
for (int i = 0; i < scores.Length; i++) 
{
   scores[i] = new int[4];
}

您可以初始化一个交错数组，如下所示：
int[][] scores = new int[2][]{new int[]{92,93,94},new int[]{85,66,87,88}};

其中，scores 是一个由两个整型数组组成的数组 -- scores[0] 是一个带有 3 个整数的数组，scores[1] 是一个带有 4 个整数的数组。


*/

		static void test4()
        {
            /* 一个由 5 个整型数组组成的交错数组 */
            int[][] a = new int[][]{new int[]{0,0},new int[]{1,2},
            new int[]{2,4},new int[]{ 3, 6 }, new int[]{ 4, 8 } };

            int i, j;

            /* 输出数组中每个元素的值 */
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            }
           Console.ReadKey();
        }

/*
C# 传递数组给函数
C# 数组 C# 数组
在 C# 中，您可以传递数组作为函数的参数。您可以通过指定不带索引的数组名称来给函数传递一个指向数组的指针。
*/
	  double getAverage(int[] arr, int size)
      {
         int i;
         double avg;
         int sum = 0;

         for (i = 0; i < size; ++i)
         {
            sum += arr[i];
         }

         avg = (double)sum / size;
         return avg;
      }
      static void test5()
      {
         MyArray app = new MyArray();
         /* 一个带有 5 个元素的 int 数组 */
         int [] balance = new int[]{1000, 2, 3, 17, 50};
         double avg;

         /* 传递数组的指针作为参数 */
         avg = app.getAverage(balance, 5 ) ;

         /* 输出返回值 */
         Console.WriteLine( "平均值是： {0} ", avg );
         Console.ReadKey();
      }

/*
C# 参数数组
C# 数组 C# 数组
有时，当声明一个方法时，您不能确定要传递给函数作为参数的参数数目。C# 参数数组解决了这个问题，参数数组通常用于传递未知数量的参数给函数。
params 关键字
在使用数组作为形参时，C# 提供了 params 关键字，使调用数组为形参的方法时，既可以传递数组实参，也可以传递一组数组元素。params 的使用格式为：
public 返回类型 方法名称( params 类型名称[] 数组名称 )
*/
		class ParamArray
   		{
      		public int AddElements(params int[] arr)
      		{
         		int sum = 0;
         		foreach (int i in arr)
         		{
            		sum += i;
         		}
         		return sum;
      		}
   		}
     
      	static void test6()
      	{
         	ParamArray app = new ParamArray();
         	int sum = app.AddElements(512, 720, 250, 567, 889);
         	Console.WriteLine("总和是： {0}", sum);
         	Console.ReadKey();
      	}

/*
C# Array 类
C# 数组 C# 数组
Array 类是 C# 中所有数组的基类，它是在 System 命名空间中定义。Array 类提供了各种用于数组的属性和方法。
Array 类的属性

下表列出了 Array 类中一些最常用的属性：
序号	属性 & 描述
1	IsFixedSize 获取一个值，该值指示数组是否带有固定大小。

2	IsReadOnly 获取一个值，该值指示数组是否只读。

3	Length 获取一个 32 位整数，该值表示所有维度的数组中的元素总数。

4	LongLength 获取一个 64 位整数，该值表示所有维度的数组中的元素总数。

5	Rank 获取数组的秩（维度）。


Array 类的方法
下表列出了 Array 类中一些最常用的方法：
序号	方法 & 描述
1	Clear 根据元素的类型，设置数组中某个范围的元素为零、为 false 或者为 null。

2	Copy(Array, Array, Int32) 从数组的第一个元素开始复制某个范围的元素到另一个数组的第一个元素位置。长度由一个 32 位整数指定。

3	CopyTo(Array, Int32) 从当前的一维数组中复制所有的元素到一个指定的一维数组的指定索引位置。索引由一个 32 位整数指定。

4	GetLength 获取一个 32 位整数，该值表示指定维度的数组中的元素总数。

5	GetLongLength 获取一个 64 位整数，该值表示指定维度的数组中的元素总数。

6	GetLowerBound 获取数组中指定维度的下界。

7	GetType 获取当前实例的类型。从对象（Object）继承。

8	GetUpperBound 获取数组中指定维度的上界。

9	GetValue(Int32) 获取一维数组中指定位置的值。索引由一个 32 位整数指定。

10	IndexOf(Array, Object) 搜索指定的对象，返回整个一维数组中第一次出现的索引。

11	Reverse(Array) 逆转整个一维数组中元素的顺序。

12	SetValue(Object, Int32) 给一维数组中指定位置的元素设置值。索引由一个 32 位整数指定。

13	Sort(Array) 使用数组的每个元素的 IComparable 实现来排序整个一维数组中的元素。

14	ToString 返回一个表示当前对象的字符串。从对象（Object）继承。

*/

		static void test7()
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };

            Console.Write("原始数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
           
            // 逆转数组
            Array.Reverse(list);
            Console.Write("逆转数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
           
            // 排序数组
            Array.Sort(list);
            Console.Write("排序数组： ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

           Console.ReadKey();
        }
   }
}





























