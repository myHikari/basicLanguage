package main

import "fmt"
import "unsafe"

/*
iota：特殊常量，可以认为是一个可以被编译器修改的常量
iota：在 const关键字出现时将被重置为 0(const 内部的第一行之前)，const 中每新增一行常量声明将使 iota 计数一次(iota 可理解为 const 语句块中的行索引)
*/

const (
    x = "abc"
    y = len(x)
    z = unsafe.Sizeof(x)
)


func main() {
   const LENGTH int = 10
   const WIDTH int = 5  
   var area int
   
   // 多重赋值
   const a, b, c = 1, false, "str"

   area = LENGTH * WIDTH
   fmt.Printf("面积为 : %d", area)
   println()
   println(a, b, c)  
   println(x, y, z)
}
