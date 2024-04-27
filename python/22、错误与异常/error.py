"""
Python3 错误和异常
作为 Python 初学者，在刚学习 Python 编程时，经常会看到一些报错信息，在前面我们没有提及，这章节我们会专门介绍。
Python 有两种错误很容易辨认：语法错误和异常。

Python assert（断言）用于判断一个表达式，在表达式条件为 false 的时候触发异常。

语法错误
Python 的语法错误或者称之为解析错，是初学者经常碰到的，如下实例
>>> while True print('Hello world')
  File "<stdin>", line 1, in ?
    while True print('Hello world')
                   ^
SyntaxError: invalid syntax
这个例子中，函数 print() 被检查到有错误，是它前面缺少了一个冒号 : 。



异常
即便 Python 程序的语法是正确的，在运行它的时候，也有可能发生错误。运行期检测到的错误被称为异常。
大多数的异常都不会被程序处理，都以错误信息的形式展现在这里:

实例
>>> 10 * (1/0)             # 0 不能作为除数，触发异常
Traceback (most recent call last):
  File "<stdin>", line 1, in ?
ZeroDivisionError: division by zero
>>> 4 + spam*3             # spam 未定义，触发异常
Traceback (most recent call last):
  File "<stdin>", line 1, in ?
NameError: name 'spam' is not defined
>>> '2' + 2               # int 不能与 str 相加，触发异常
Traceback (most recent call last):
  File "<stdin>", line 1, in <module>
TypeError: can only concatenate str (not "int") to str

异常以不同的类型出现，这些类型都作为信息的一部分打印出来: 例子中的类型有 ZeroDivisionError，NameError 和 TypeError。
错误信息的前面部分显示了异常发生的上下文，并以调用栈的形式显示具体信息。 

"""


"""
异常处理
try/except
异常捕捉可以使用 try/except 语句。

try:
	执行代码
except:
	发生异常时执行的代码



try 语句按照如下方式工作；
    首先，执行 try 子句（在关键字 try 和关键字 except 之间的语句）。
    如果没有异常发生，忽略 except 子句，try 子句执行后结束。
    如果在执行 try 子句的过程中发生了异常，那么 try 子句余下的部分将被忽略。如果异常的类型和 except 之后的名称相符，那么对应的 except 子句将被执行。
    如果一个异常没有与任何的 except 匹配，那么这个异常将会传递给上层的 try 中。

一个 try 语句可能包含多个except子句，分别来处理不同的特定的异常。最多只有一个分支会被执行。
处理程序将只针对对应的 try 子句中的异常进行处理，而不是其他的 try 的处理程序中的异常。

一个except子句可以同时处理多个异常，这些异常将被放在一个括号里成为一个元组，例如:
except (RuntimeError, TypeError, NameError):
    pass
"""
import sys

try:
    f = open('myfile.txt')
    s = f.readline()
    i = int(s.strip())
except OSError as err:
    print("OS error: {0}".format(err))
except ValueError:
    print("Could not convert data to an integer.")
except:
    print("Unexpected error:", sys.exc_info()[0])
    raise


"""
try/except...else
try/except 语句还有一个可选的 else 子句，如果使用这个子句，那么必须放在所有的 except 子句之后。
else 子句将在 try 子句没有发生任何异常的时候执行。

try:
	执行代码
except:
	发生异常时执行的代码
else:
	没有异常时执行的代码
"""
for arg in sys.argv[1:]:
    try:
        f = open(arg, 'r')
    except IOError:
        print('cannot open', arg)
    else:
        print(arg, 'has', len(f.readlines()), 'lines')
        f.close()

def this_fails():
        x = 1/0
   
try:
	this_fails()
except ZeroDivisionError as err:
    print('Handling run-time error:', err)



"""
try-finally 语句
try-finally 语句无论是否发生异常都将执行最后的代码


try:
	执行代码
except:
	发生异常时执行的代码
else:
	没有异常时执行的代码
finally:
	不管有没异常都会执行的代码



try:
    runoob()
except AssertionError as error:
    print(error)
else:
    try:
        with open('file.log') as file:
            read_data = file.read()
    except FileNotFoundError as fnf_error:
        print(fnf_error)
finally:
    print('这句话，无论异常是否发生都会执行。')

Traceback (most recent call last):
  File "/home/goes/code/python/22、错误与异常/error.py", line 130, in <module>
    runoob()
NameError: name 'runoob' is not defined

"""


"""
抛出异常
Python 使用 raise 语句抛出一个指定的异常。

raise语法格式如下：
raise [Exception [, args [, traceback]]]


x = 10
if x > 5:
    raise Exception('x 不能大于 5。x 的值为: {}'.format(x))

Traceback (most recent call last):
  File "/home/goes/code/python/22、错误与异常/error.py", line 160, in <module>
    raise Exception('x 不能大于 5。x 的值为: {}'.format(x))
Exception: x 不能大于 5。x 的值为: 10
"""

# raise 唯一的一个参数指定了要被抛出的异常。它必须是一个异常的实例或者是异常的类（也就是 Exception 的子类）。
# 如果你只想知道这是否抛出了一个异常，并不想去处理它，那么一个简单的 raise 语句就可以再次把它抛出。
"""
try:
    raise NameError('HiThere')  # 模拟一个异常。
except NameError:
    print('An exception flew by!')
    raise

Traceback (most recent call last):
  File "/home/goes/code/python/22、错误与异常/error.py", line 172, in <module>
    raise NameError('HiThere')  # 模拟一个异常。
NameError: HiThere
"""





# 用户自定义异常
# 你可以通过创建一个新的异常类来拥有自己的异常。异常类继承自 Exception 类，可以直接继承，或者间接继承
# 例如:
class MyError(Exception):
    def __init__(self, value):
        self.value = value
    def __str__(self):
        return repr(self.value)
   
try:
    raise MyError(2*2)
except MyError as e:
    print('My exception occurred, value:', e.value)
"""
raise MyError('oops!')

Traceback (most recent call last):
  File "/home/goes/code/python/22、错误与异常/error.py", line 202, in <module>
    raise MyError('oops!')
__main__.MyError: 'oops!'
"""


"""
类 Exception 默认的 __init__() 被覆盖。
当创建一个模块有可能抛出多种不同的异常时，一种通常的做法是为这个包建立一个基础异常类，然后基于这个基础类为不同的错误情况创建不同的子类:
"""

class Error(Exception):
    """Base class for exceptions in this module."""
    pass

class InputError(Error):
    """Exception raised for errors in the input.

    Attributes:
        expression -- input expression in which the error occurred
        message -- explanation of the error
    """

    def __init__(self, expression, message):
        self.expression = expression
        self.message = message

class TransitionError(Error):
    """Raised when an operation attempts a state transition that's not
    allowed.

    Attributes:
        previous -- state at beginning of transition
        next -- attempted new state
        message -- explanation of why the specific transition is not allowed
    """

    def __init__(self, previous, next, message):
        self.previous = previous
        self.next = next
        self.message = message





"""
定义清理行为
try 语句还有另外一个可选的子句，它定义了无论在任何情况下都会执行的清理行为。 例如:


try:
	raise KeyboardInterrupt
finally:
	print('Goodbye, world!')

Traceback (most recent call last):
  File "/home/goes/code/python/22、错误与异常/error.py", line 258, in <module>
    raise KeyboardInterrupt
KeyboardInterrupt

"""


def divide(x, y):
	try:
		result = x / y
	except ZeroDivisionError:
		print("division by zero!")
	else:
		print("result is", result)
	finally:
		print("executing finally clause")

divide(2, 1)
divide(2, 0)
"""
divide("2", "1")

Traceback (most recent call last):
  File "/home/goes/code/python/22、错误与异常/error.py", line 281, in <module>
    divide("2", "1")
  File "/home/goes/code/python/22、错误与异常/error.py", line 271, in divide
    result = x / y
TypeError: unsupported operand type(s) for /: 'str' and 'str'


"""

"""
预定义的清理行为
一些对象定义了标准的清理行为，无论系统是否成功的使用了它，一旦不需要它了，那么这个标准的清理行为就会执行。


下面这个例子展示了尝试打开一个文件，然后把内容打印到屏幕上:
for line in open("myfile.txt"):
    print(line, end="")
以上这段代码的问题是，当执行完毕后，文件会保持打开状态，并没有被关闭。


关键词 with 语句就可以保证诸如文件之类的对象在使用完之后一定会正确的执行他的清理方法:
with open("myfile.txt") as f:
    for line in f:
        print(line, end="")
以上这段代码执行完毕后，就算在处理过程中出问题了，文件 f 总是会关闭。 
"""
























