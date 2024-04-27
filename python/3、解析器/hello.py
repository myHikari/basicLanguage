"""
交互式编程
在命令提示符中输入"Python"命令来启动Python解释器：

$ python3
Python 3.10.12 (main, Jun 11 2023, 05:26:28) [GCC 11.4.0] on linux
Type "help", "copyright", "credits" or "license" for more information.
>>> 




 脚本式编程
将如下代码拷贝至 hello.py文件中：
print ("Hello, Python!");

通过以下命令执行该脚本：
python3 hello.py


 在Linux/Unix系统中，你可以在脚本顶部添加以下命令让Python脚本可以像SHELL脚本一样可直接执行：
#! /usr/bin/env python3

然后修改脚本权限，使其有执行权限，命令如下：
$ chmod +x hello.py

执行以下命令：
./hello.py


注意：以脚本式编程方式编程时不可以使用多行注释，且 “#!/usr/bin/env python3” 该脚本声明必须置于文件首行

"""
#!/usr/bin/env python3
print("Hello, Python3!"); # Hello, Python3!




