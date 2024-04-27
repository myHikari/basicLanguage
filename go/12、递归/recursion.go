package main

import "fmt"


//  阶乘
func Factorial(n uint64)(result uint64) {
    if (n > 0) {
        result = n * Factorial(n-1)
        return result
    }
    return 1
}


//  斐波那契数列
func fibonacci(n int) int {
  if n < 2 {
   return n
  }
  return fibonacci(n-2) + fibonacci(n-1)
}


//  求平方根
func sqrtRecursive(x, guess, prevGuess, epsilon float64) float64 {
    if diff := guess*guess - x; diff < epsilon && -diff < epsilon {
         return guess
    }

    newGuess := (guess + x/guess) / 2
    if newGuess == prevGuess {
         return guess
    }

    return sqrtRecursive(x, newGuess, guess, epsilon)
}

func sqrt(x float64) float64 {
    return sqrtRecursive(x, 1.0, 0.0, 1e-9)
}


func main() {
    println("阶乘")
    var i int = 15
    fmt.Printf("%d 的阶乘是 %d\n", i, Factorial(uint64(i)))
    
    println("----------------")
    
    println("斐波那契数列")
    var j int
    for j = 0; j < 10; j++ {
       fmt.Printf("%d\t", fibonacci(i))
    }
    println()
    
    println("----------------")

    println("求平方根")
    x := 25.0
    result := sqrt(x)
    fmt.Printf("%.2f 的平方根为 %.6f\n", x, result)
}






