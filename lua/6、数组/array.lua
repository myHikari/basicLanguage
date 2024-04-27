--[[
数组，就是相同数据类型的元素按一定顺序排列的集合，可以是一维数组和多维数组。
在 Lua 中，数组不是一种特定的数据类型，而是一种用来存储一组值的数据结构。
实际上，Lua 中并没有专门的数组类型，而是使用一种被称为 "table" 的数据结构来实现数组的功能。
Lua 数组的索引键值可以使用整数表示，数组的大小不是固定的。
在 Lua 索引值是以 1 为起始，但你也可以指定 0 开始。 

--]]

--[[   访问数组元素    --]]
-- 创建一个数组
local myArray = {10, 20, 30, 40, 50}
-- 访问数组元素
print(myArray[1])  -- 输出 10
print(myArray[3])  -- 输出 30



local myArray = {10, 20, 30, 40, 50}
-- 计算数组长度
local length = #myArray
print(length) -- 输出 5


--[[  循环遍历数组   --]]
-- 创建一个数组
local myArray = {10, 20, 30, 40, 50}
-- 循环遍历数组
for i = 1, #myArray do
    print(myArray[i])
end


-- lua 索引默认从 1 开始：
array = {"Lua", "Tutorial"}
for i= 0, 2 do
   print(array[i])
end


-- 以负数为数组索引值：
array = {}
for i= -2, 2 do
   array[i] = i *2
end

for i = -2,2 do
   print(array[i])
end



--[[   修改数组中元素   --]]
-- 创建一个数组
local myArray = {10, 20, 30, 40, 50}
-- 修改数组元素
myArray[2] = 25
-- 循环遍历数组
for i = 1, #myArray do
    print(myArray[i])
end



--[[   向数组中添加元素   --]]
-- 创建一个数组
local myArray = {10, 20, 30, 40, 50}
-- 添加新元素到数组末尾
myArray[#myArray + 1] = 60
-- 循环遍历数组
for i = 1, #myArray do
    print(myArray[i])
end


--[[   删除数组中元素   --]]
-- 创建一个数组
local myArray = {10, 20, 30, 40, 50}
-- 删除第三个元素
table.remove(myArray, 3)
-- 循环遍历数组
for i = 1, #myArray do
    print(myArray[i])
end


--[[
多维数组
多维数组即数组中包含数组或一维数组的索引键对应一个数组。

--]]

-- 初始化数组
array = {}
for i=1,3 do
   array[i] = {}
      for j=1,3 do
         array[i][j] = i*j
      end
end
-- 访问数组
for i=1,3 do
   for j=1,3 do
      print(array[i][j])
   end
end



-- 初始化数组
array = {}
maxRows = 3
maxColumns = 3
for row=1,maxRows do
   for col=1,maxColumns do
      array[row*maxColumns + col] = row*col
   end
end
-- 访问数组
for row=1,maxRows do
   for col=1,maxColumns do
      print(array[row*maxColumns + col])
   end
end
















































