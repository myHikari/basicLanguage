/*
类型转换用于将一种数据类型的变量转换为另外一种类型的变量。

Go 语言类型转换基本格式如下：
type_name(expression)
type_name 为类型，expression 为表达式



字符串类型转换
将一个字符串转换成另一个类型，可以使用以下语法：
1、string to int
{
    var str string = "10"
    var num int
    num, _ = strconv.Atoi(str)
}

2、int to string
{
    num := 200
   str := strconv.Itoa(num)
}
以上代码将字符串变量 str 转换为整型变量 num
注意，strconv.Atoi 函数返回两个值，第一个是转换后的整型值，第二个是可能发生的错误，我们可以使用空白标识符 _ 来忽略这个错误
*/

package main

import (
    "fmt"
    "strconv"
)


func main() {
    println("数值类型转换")
    println("实例一")
    test1()
    
    println("============================")
    
    println("字符串类型转换")
    println("实例二")
    test2()
    
    println("----------------")
    
    println("实例三")
    test3()
    
    println("----------------")
    
    println("实例四")
    test4()
    
    println("----------------")
    
    println("实例五")
    test5()
    
    println("============================")
    
    println("接口类型转换")
    println("实例六")
    test6()
    
    println("----------------")
    
    println("实例七")
    test7()
}


// 将整型转化为浮点型
func test1() {
   var sum int = 17
   var count int = 5
   var mean float32
   
   mean = float32(sum)/float32(count)
   fmt.Printf("mean 的值为: %f\n",mean)
}

// 字符串转换为整数
func test2() {
    str := "123"
    num, err := strconv.Atoi(str)
    if err != nil {
        fmt.Println("转换错误:", err)
    } else {
        fmt.Printf("字符串 '%s' 转换为整数为：%d\n", str, num)
    }
}

// 整数转换为字符串：
func test3() {
    num := 123
    str := strconv.Itoa(num)
    fmt.Printf("整数 %d  转换为字符串为：'%s'\n", num, str)
}

// 将字符串转换为浮点数：
func test4() {
    str := "3.14"
    num, err := strconv.ParseFloat(str, 64)
    if err != nil {
        fmt.Println("转换错误:", err)
    } else {
        fmt.Printf("字符串 '%s' 转为浮点型为：%f\n", str, num)
    }
}

// 将浮点数转换为字符串：
func test5() {
    num := 3.14
    str := strconv.FormatFloat(num, 'f', 2, 64)
    fmt.Printf("浮点数 %f 转为字符串为：'%s'\n", num, str)
}


/*
接口类型转换
接口类型转换有两种情况：类型断言和类型转换。

类型断言用于将接口类型转换为指定类型，其语法为：

value.(type) 
或者 
value.(T)
其中 value 是接口类型的变量，type 或 T 是要转换成的类型。

如果类型断言成功，它将返回转换后的值和一个布尔值，表示转换是否成功。



类型转换用于将一个接口类型的值转换为另一个接口类型，其语法为：

T(value)
T 是目标接口类型，value 是要转换的值。

在类型转换中，我们必须保证要转换的值和目标接口类型之间是兼容的，否则编译器会报错。
*/


func test6() {
    var i interface{} = "Hello, World"
    str, ok := i.(string)
    if ok {
        fmt.Printf("'%s' is a string\n", str)
    } else {
        fmt.Println("conversion failed")
    }
}

type Writer interface {
    Write([]byte) (int, error)
}

type StringWriter struct {
    str string
}

func (sw *StringWriter) Write(data []byte) (int, error) {
    sw.str += string(data)
    return len(data), nil
}

func test7() {
    var w Writer = &StringWriter{}
    sw := w.(*StringWriter)
    sw.str = "Hello, World"
    fmt.Println(sw.str)
}


















