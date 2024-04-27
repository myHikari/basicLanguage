#!/usr/bin/python3
"""
Python3 字典
字典是另一种可变容器模型，且可存储任意类型对象。
字典的每个键值 key=>value 对用冒号 : 分割，每个对之间用逗号(,)分割，整个字典包括在花括号 {} 中 ,格式如下所示：
d = {key1 : value1, key2 : value2, key3 : value3 }

"""
# 创建空字典

# 使用大括号 { } 创建空字典：
emptyDict = {}
# 打印字典
print(emptyDict)
# 查看字典的数量
print("Length:", len(emptyDict))
# 查看类型
print(type(emptyDict))


# 使用内建函数 dict() 创建字典：
emptyDict = dict()
# 打印字典
print(emptyDict)
# 查看字典的数量
print("Length:",len(emptyDict))
# 查看类型
print(type(emptyDict))



# 访问字典里的值
tinydict = {'Name': 'Runoob', 'Age': 7, 'Class': 'First'}
 
print ("tinydict['Name']: ", tinydict['Name'])
print ("tinydict['Age']: ", tinydict['Age'])




# 删除字典元素
# 能删单一的元素也能清空字典，清空只需一项操作。
tinydict = {'Name': 'Runoob', 'Age': 7, 'Class': 'First'}
 
del tinydict['Name'] # 删除键 'Name'
tinydict.clear()     # 清空字典
del tinydict         # 删除字典
# print ("tinydict['Age']: ", tinydict['Age'])
# print ("tinydict['School']: ", tinydict['School'])





"""
字典键的特性
字典值可以是任何的 python 对象，既可以是标准的对象，也可以是用户定义的，但键不行。

两个重要的点需要记住：
1）不允许同一个键出现两次。创建时如果同一个键被赋值两次，后一个值会被记住，如下实例：
2）键必须不可变，所以可以用数字，字符串或元组充当，而用列表就不行，

"""




"""
字典内置函数&方法

Python字典包含了以下内置函数：
序号		函数及描述			实例
1		len(dict)			计算字典元素个数，即键的总数。 	

>>> tinydict = {'Name': 'Runoob', 'Age': 7, 'Class': 'First'}
>>> len(tinydict)
3

2		str(dict)			输出字典，可以打印的字符串表示。 	

>>> tinydict = {'Name': 'Runoob', 'Age': 7, 'Class': 'First'}
>>> str(tinydict)
"{'Name': 'Runoob', 'Class': 'First', 'Age': 7}"

3		type(variable)		返回输入的变量类型，如果变量是字典就返回字典类型。 	

>>> tinydict = {'Name': 'Runoob', 'Age': 7, 'Class': 'First'}
>>> type(tinydict)
<class 'dict'>

Python字典包含了以下内置方法：
序号		函数及描述
1		dict.clear()							删除字典内所有元素
2		dict.copy()								返回一个字典的浅复制
3		dict.fromkeys()							创建一个新字典，以序列seq中元素做字典的键，val为字典所有键对应的初始值
4		dict.get(key, default=None)				返回指定键的值，如果键不在字典中返回 default 设置的默认值
5		key in dict								如果键在字典dict里返回true，否则返回false
6		dict.items()							以列表返回一个视图对象
7		dict.keys()								返回一个视图对象
8		dict.setdefault(key, default=None)		和get()类似, 但如果键不存在于字典中，将会添加键并将值设为default
9		dict.update(dict2)						把字典dict2的键/值对更新到dict里
10		dict.values()							返回一个视图对象
11		pop(key[,default])						删除字典 key（键）所对应的值，返回被删除的值。
12		popitem()								返回并删除字典中的最后一对键和值。

"""











