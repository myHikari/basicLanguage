/*
C# 不安全代码
当一个代码块使用 unsafe 修饰符标记时，C# 允许在函数中使用指针变量。不安全代码或非托管代码是指使用了指针变量的代码块。

指针变量
指针 是值为另一个变量的地址的变量，即，内存位置的直接地址。就像其他变量或常量，您必须在使用指针存储其他变量地址之前声明指针。
指针变量声明的一般形式为：
type* var-name;

下面是指针类型声明的实例：
实例 			描述
int* p 			p 是指向整数的指针。
double* p 		p 是指向双精度数的指针。
float* p 		p 是指向浮点数的指针。
int** p 		p 是指向整数的指针的指针。
int*[] p 		p 是指向整数的指针的一维数组。
char* p 		p 是指向字符的指针。
void* p 		p 是指向未知类型的指针。

在同一个声明中声明多个指针时，星号 * 仅与基础类型一起写入；而不是用作每个指针名称的前缀。 例如:
int* p1, p2, p3;     // 正确  
int *p1, *p2, *p3;   // 错误 



使用指针检索数据值
您可以使用 ToString() 方法检索存储在指针变量所引用位置的数据。
*/

using System;
namespace UnsafeCodeApplication
{
	class Tester {
		static void Main() {
		 
			Program.test1();
			Program.test2();
	
			TestPointer.test3();
			TestPointer.test4();
		}
	}
	
    class Program
    {
        public static unsafe void test1()
        {
            int var = 20;
            int* p = &var;
            Console.WriteLine("Data is: {0} ",  var);
            Console.WriteLine("Address is: {0}",  (int)p);
            Console.ReadKey();
        }
        
        
        public static void test2()
      	{
         	unsafe
         	{
            	int var = 20;
            	int* p = &var;
            	Console.WriteLine("Data is: {0} " , var);
           		Console.WriteLine("Data is: {0} " , p->ToString());
            	Console.WriteLine("Address is: {0} " , (int)p);
         	}
         	Console.ReadKey();
      	}
    }
    
    class TestPointer
   	{
      	public unsafe void swap(int* p, int *q)
      	{
         	int temp = *p;
         	*p = *q;
         	*q = temp;
      	}

      	public unsafe static void test3()
      	{
         	TestPointer p = new TestPointer();
         	int var1 = 10;
         	int var2 = 20;
         	int* x = &var1;
         	int* y = &var2;
         
         	Console.WriteLine("Before Swap: var1:{0}, var2: {1}", var1, var2);
         	p.swap(x, y);

         	Console.WriteLine("After Swap: var1:{0}, var2: {1}", var1, var2);
         	Console.ReadKey();
      	}
      	
      	/*
   		使用指针访问数组元素
		在 C# 中，数组名称和一个指向与数组数据具有相同数据类型的指针是不同的变量类型。
		例如，int *p 和 int[] p 是不同的类型。您可以增加指针变量 p，因为它在内存中不是固定的，但是数组地址在内存中是固定的，所以您不能增加数组 p。
		因此，如果您需要使用指针变量访问数组数据，可以像我们通常在 C 或 C++ 中所做的那样，使用 fixed 关键字来固定指针。
   		*/
      	public unsafe static void test4()
      	{
         	int[]  list = {10, 100, 200};
         	fixed(int *ptr = list)

         	/* 显示指针中数组地址 */
         	for ( int i = 0; i < 3; i++)
         	{
            	Console.WriteLine("Address of list[{0}]={1}", i, (int)(ptr + i));
            	Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
         	}
        	Console.ReadKey();
      	}
   	}

   	
   	/*
   	编译不安全代码
	为了编译不安全代码，您必须切换到命令行编译器指定 /unsafe 命令行。

	例如，为了编译包含不安全代码的名为 prog1.cs 的程序，需在命令行中输入命令：
	csc /unsafe prog1.cs

	如果您使用的是 Visual Studio IDE，那么您需要在项目属性中启用不安全代码。
	步骤如下：
    		通过双击资源管理器（Solution Explorer）中的属性（properties）节点，打开项目属性（project properties）。
    		点击 Build 标签页。
    		选择选项"Allow unsafe code"。

   	*/
}


















