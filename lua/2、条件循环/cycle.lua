#!/usr/local/bin/lua

--[[
Lua 编程语言中 while 循环语句在判断条件为 true 时会重复执行循环体语句。

Lua 编程语言中 while 循环语法：
while(condition)
do
   statements
end

statements(循环体语句) 可以是一条或多条语句，condition(条件) 可以是任意表达式，在 condition(条件) 为 true 时执行循环体语句。

--]]

a=10
while( a < 20 )
do
   print("a 的值为:", a)
   a = a+1
end


--[[
Lua 编程语言中 for 循环语句可以重复执行指定语句，重复次数可在 for 语句中控制。

Lua 编程语言中 for语句有两大类：数值for循环 + 泛型for循环

数值for循环
Lua 编程语言中数值 for 循环语法格式:
for var=exp1,exp2,exp3 do  
    <执行体>  
end  
var 从 exp1 变化到 exp2，每次变化以 exp3 为步长递增 var，并执行一次 "执行体"。exp3 是可选的，如果不指定，默认为1。

泛型for循环
泛型 for 循环通过一个迭代器函数来遍历所有值，类似 java 中的 foreach 语句。
Lua 编程语言中泛型 for 循环语法格式:
--打印数组a的所有值  
a = {"one", "two", "three"}
for i, v in ipairs(a) do
    print(i, v)
end 

i是数组索引值，v是对应索引的数组元素值。ipairs是Lua提供的一个迭代器函数，用来迭代数组。

--]]

-- 数值for循环
function f(x)  
    print("function")  
    return x*2  
end  
for i=1,f(5) do print(i)  
end

-- 泛型for循环
days = {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"}  
for i,v in ipairs(days) do  print(v) end 







--[[
Lua 编程语言中 repeat...until 循环语句不同于 for 和 while循环，for 和 while 循环的条件语句在当前循环执行开始时判断，而 repeat...until 循环的条件语句在当前循环结束后判断。

Lua 编程语言中 repeat...until 循环语法格式:

repeat
   statements
until( condition )

我们注意到循环条件判断语句（condition）在循环体末尾部分，所以在条件进行判断前循环体都会执行一次。
如果条件判断语句（condition）为 false，循环会重新开始执行，直到条件判断语句（condition）为 true 才会停止执行。
--]]

--[ 变量定义 --]
a = 10
--[ 执行循环 --]
repeat
   print("a的值为:", a)
   a = a + 1
until( a > 15 )

































