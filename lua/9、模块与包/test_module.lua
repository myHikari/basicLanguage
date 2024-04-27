--[[
require 函数
Lua提供了一个名为require的函数用来加载模块。要加载一个模块，只需要简单地调用就可以了。例如：

require("<模块名>")
或者
require "<模块名>"

执行 require 后会返回一个由模块常量或函数组成的 table，并且还会定义一个包含该 table 的全局变量。 

--]]

-- test_module.lua 文件
-- module 模块为上文提到到 module.lua

require("module")
print(module.constant)
module.func3()



-- test_module.lua 文件
-- module 模块为上文提到到 module.lua
-- 别名变量 m

local m = require("module")
print(m.constant)
m.func3()


local path = "/usr/local/lua/lib/libluasocket.so"
-- 或者 path = "C:\\windows\\luasocket.dll"，这是 Window 平台下
local f = assert(loadlib(path, "luaopen_socket"))
f()  -- 真正打开库










