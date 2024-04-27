--[[
5.2 版本之后，require 不再定义全局变量，需要保存其返回值。

require "luasql.mysql"
需要写成:
luasql = require "luasql.mysql"

--]]

-- require "luasql.mysql"
luasql = require "luasql.mysql"

-- 创建环境对象
env = luasql.mysql()

-- 连接数据库
conn, err = env:connect("luaDb", "goes", "goes", "localhost", 3306)
if not conn then
    print("连接数据库失败:", err)
    return
end

-- 设置数据库的编码格式
conn:execute("SET NAMES UTF8")

-- 执行数据库操作
cur, err = conn:execute("select * from role")
if not cur then
    print("执行查询失败:", err)
    return
end

row = cur:fetch({}, "a")

-- 文件对象的创建
file = io.open("role.txt", "w+")

while row do
    var = string.format("%d %s\n", row.id, row.name)

    print(var)

    file:write(var)

    row = cur:fetch({}, "a")
end

file:close()  -- 关闭文件对象
cur:close()   -- 关闭游标对象
conn:close()  -- 关闭数据库连接
env:close()   -- 关闭数据库环境



