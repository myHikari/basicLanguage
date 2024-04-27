package main
import "fmt"

var x, y int

// 这种因式分解关键字的写法一般用于声明全局变量
var(
    a int
    b bool
)

// 这种不带声明格式的只能在函数体中出现
// g, h := 123, "hello"

func main() {
    g, h := 123, "hello"
    fmt.Println(x, y, a, b, g, h)
}
