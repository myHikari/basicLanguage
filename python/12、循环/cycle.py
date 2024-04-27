#!/usr/bin/env python3
"""
while 循环
Python 中 while 语句的一般形式：
while 判断条件(condition)：
    执行语句(statements)……

"""
n = 100
 
sum = 0
counter = 1
while counter <= n:
    sum = sum + counter
    counter += 1
 
print("1 到 %d 之和为: %d" % (n,sum))



"""
var = 1
while var == 1 :  # 表达式永远为 true
   num = int(input("输入一个数字  :"))
   print ("你输入的数字是: ", num)
 
print ("Good bye!")

"""


"""
while 循环使用 else 语句
如果 while 后面的条件语句为 false 时，则执行 else 的语句块。

语法格式如下：
while <expr>:
    <statement(s)>
else:
    <additional_statement(s)>

"""
count = 0
while count < 5:
   print (count, " 小于 5")
   count = count + 1
else:
   print (count, " 大于或等于 5")



"""
flag = 1
while (flag): 
	print ('欢迎访问菜鸟教程!')
print ("Good bye!")
"""



"""
for 语句
Python for 循环可以遍历任何可迭代对象，如一个列表或者一个字符串。

for循环的一般格式如下：
for <variable> in <sequence>:
    <statements>
else:
    <statements>

"""
sites = ["Baidu", "Google","Runoob","Taobao"]
for site in sites:
    print(site)


word = 'runoob'
for letter in word:
    print(letter)



#  整数范围值可以配合 range() 函数使用：
#  1 到 5 的所有数字：
for number in range(1, 6):
    print(number)



"""
for...else
在 Python 中，for...else 语句用于在循环结束后执行一段代码。
语法格式如下：
for item in iterable:
    # 循环主体
else:
    # 循环结束后执行的代码

当循环执行完毕（即遍历完 iterable 中的所有元素）后，会执行 else 子句中的代码，如果在循环过程中遇到了 break 语句，则会中断循环，此时不会执行 else 子句。

"""

for x in range(6):
  print(x)
else:
  print("Finally finished!")


sites = ["Baidu", "Google","Runoob","Taobao"]
for site in sites:
    if site == "Runoob":
        print("菜鸟教程!")
        break
    print("循环数据 " + site)
else:
    print("没有循环数据!")
print("完成循环!")






"""
break 语句可以跳出 for 和 while 的循环体。如果你从 for 或 while 循环中终止，任何对应的循环 else 块将不执行。
continue 语句被用来告诉 Python 跳过当前循环块中的剩余语句，然后继续进行下一轮循环。 

"""
n = 5
while n > 0:
    n -= 1
    if n == 2:
        break
    print(n)
print('循环结束。')


n = 5
while n > 0:
    n -= 1
    if n == 2:
        continue
    print(n)
print('循环结束。')


for letter in 'Runoob':     # 第一个实例
   if letter == 'b':
      break
   print ('当前字母为 :', letter)
  
var = 10                    # 第二个实例
while var > 0:              
   print ('当前变量值为 :', var)
   var = var -1
   if var == 5:
      break
 
print ("Good bye!")



for letter in 'Runoob':     # 第一个实例
   if letter == 'o':        # 字母为 o 时跳过输出
      continue
   print ('当前字母 :', letter)
 
var = 10                    # 第二个实例
while var > 0:              
   var = var -1
   if var == 5:             # 变量为 5 时跳过输出
      continue
   print ('当前变量值 :', var)
print ("Good bye!")




"""
pass 语句
Python pass是空语句，是为了保持程序结构的完整性。
pass 不做任何事情，一般用做占位语句

"""

for letter in 'Runoob': 
   if letter == 'o':
      pass
      print ('执行 pass 块')
   print ('当前字母 :', letter)
 
print ("Good bye!")










