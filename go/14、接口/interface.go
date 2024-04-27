/*
Go 语言提供了另外一种数据类型即接口，它把所有的具有共性的方法定义在一起，任何其他类型只要实现了这些方法就是实现了这个接口。

接口可以让我们将不同的类型绑定到一组公共的方法上，从而实现多态和灵活的设计。

Go 语言中的接口是隐式实现的，也就是说，如果一个类型实现了一个接口定义的所有方法，那么它就自动地实现了该接口。因此，我们可以通过将接口作为参数来实现对不同类型的调用，从而实现多态。


// 定义接口 
type interface_name interface {
   method_name1 [return_type]
   method_name2 [return_type]
   method_name3 [return_type]
   ...
   method_namen [return_type]
}

// 定义结构体 
type struct_name struct {
   // variables
}

// 实现接口方法
func (struct_name_variable struct_name) method_name_1() [return_type] {
   // 方法实现
}

...

func (struct_name_variable struct_name) method_name_n() [return_type] {
   // 方法实现
}
*/

package main

import (
    "fmt"
)


func main() {
    println("实例一")
    test1()
    
    println("----------------")
    
    println("实例二")
    test2()
}


type Phone interface {
    call()
}

type NokiaPhone struct {
}

func (nokiaPhone NokiaPhone) call() {
    fmt.Println("I am Nokia, I can call you!")
}

type IPhone struct {
}

func (iPhone IPhone) call() {
    fmt.Println("I am iPhone, I can call you!")
}

func test1() {
    var phone Phone

    phone = new(NokiaPhone)
    phone.call()

    phone = new(IPhone)
    phone.call()

}


type Shape interface {
    area() float64
}

type Rectangle struct {
    width  float64
    height float64
}

func (r Rectangle) area() float64 {
    return r.width * r.height
}

type Circle struct {
    radius float64
}

func (c Circle) area() float64 {
    return 3.14 * c.radius * c.radius
}

func test2() {
    var s Shape

    s = Rectangle{width: 10, height: 5}
    fmt.Printf("矩形面积: %f\n", s.area())

    s = Circle{radius: 3}
    fmt.Printf("圆形面积: %f\n", s.area())
}



