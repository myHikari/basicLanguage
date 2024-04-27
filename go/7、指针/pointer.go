/*
什么是指针
一个指针变量指向了一个值的内存地址。

类似于变量和常量，在使用指针前你需要声明指针。
指针声明格式如下：
var var_name *var-type

var-type 为指针类型，var_name 为指针变量名，* 号用于指定变量是作为一个指针。

以下是有效的指针声明：
var ip *int        // 指向整型
var fp *float32    // 指向浮点型 


Go 空指针
当一个指针被定义后没有分配到任何变量时，它的值为 nil。
nil 指针也称为空指针。

空指针判断：

if(ptr != nil)     // ptr 不是空指针
if(ptr == nil)    // ptr 是空指针 
*/


package main

import "fmt"

func main() {
   var a int= 20   /* 声明实际变量 */
   var ip *int        /* 声明指针变量 */

   ip = &a  /* 指针变量的存储地址 */

   fmt.Printf("a 变量的地址是: %x\n", &a  )

   /* 指针变量的存储地址 */
   fmt.Printf("ip 变量储存的指针地址: %x\n", ip )

   /* 使用指针访问值 */
   fmt.Printf("*ip 变量的值: %d\n", *ip )
   
   
   // 使用空指针
   var  ptr *int
   fmt.Printf("ptr 的值为 : %x\n", ptr  )
}
