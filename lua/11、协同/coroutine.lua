--[[
Lua 协同程序(coroutine)

什么是协同(coroutine)？
Lua 协同程序(coroutine)与线程比较类似：拥有独立的堆栈，独立的局部变量，独立的指令指针，同时又与其它协同程序共享全局变量和其它大部分东西。
协同程序可以理解为一种特殊的线程，可以暂停和恢复其执行，从而允许非抢占式的多任务处理。
协同是非常强大的功能，但是用起来也很复杂。

基本语法
同程序由 coroutine 模块提供支持。
使用协同程序，你可以在函数中使用 coroutine.create 创建一个新的协同程序对象，并使用 coroutine.resume 启动它的执行。协同程序可以通过调用 coroutine.yield 来主动暂停自己的执行，并将控制权交还给调用者。

方法	描述
coroutine.create()	创建 coroutine，返回 coroutine， 参数是一个函数，当和 resume 配合使用的时候就唤醒函数调用
coroutine.resume()	重启 coroutine，和 create 配合使用
coroutine.yield()	挂起 coroutine，将 coroutine 设置为挂起状态，这个和 resume 配合使用能有很多有用的效果
coroutine.status()	查看 coroutine 的状态
注：coroutine 的状态有三种：dead，suspended，running，具体什么时候有这样的状态请参考下面的程序
coroutine.wrap（）	创建 coroutine，返回一个函数，一旦你调用这个函数，就进入 coroutine，和 create 功能重复
coroutine.running()	返回正在跑的 coroutine，一个 coroutine 就是一个线程，当使用running的时候，就是返回一个 coroutine 的线程号

--]]

function foo()
    print("协同程序 foo 开始执行")
    local value = coroutine.yield("暂停 foo 的执行")
    print("协同程序 foo 恢复执行，传入的值为: " .. tostring(value))
    print("协同程序 foo 结束执行")
end

-- 创建协同程序
local co = coroutine.create(foo)

-- 启动协同程序
local status, result = coroutine.resume(co)
print(result) -- 输出: 暂停 foo 的执行

-- 恢复协同程序的执行，并传入一个值
status, result = coroutine.resume(co, 42)
print(result) -- 输出: 协同程序 foo 恢复执行，传入的值为: 42


--[[
以上实例中，我们定义了一个名为 foo 的函数作为协同程序。在函数中，我们使用 coroutine.yield 暂停了协同程序的执行，并返回了一个值。
在主程序中，我们使用 coroutine.create 创建了一个协同程序对象，并使用 coroutine.resume 启动了它的执行。
在第一次调用 coroutine.resume 后，协同程序执行到 coroutine.yield 处暂停，并将值返回给主程序。然后，我们再次调用 coroutine.resume，并传入一个值作为协同程序恢复执行时的参数。

协同程序的状态可以通过 coroutine.status 函数获取，通过检查状态可以确定协同程序的执行情况（如运行中、已挂起、已结束等）。

--]]

-- coroutine_test.lua 文件
-- 创建了一个新的协同程序对象 co，其中协同程序函数打印传入的参数 i
co = coroutine.create(
    function(i)
        print(i);
    end
)
-- 使用 coroutine.resume 启动协同程序 co 的执行，并传入参数 1。协同程序开始执行，打印输出为 1
coroutine.resume(co, 1)   -- 1

-- 通过 coroutine.status 检查协同程序 co 的状态，输出为 dead，表示协同程序已经执行完毕
print(coroutine.status(co))  -- dead
 
print("----------")

-- 使用 coroutine.wrap 创建了一个协同程序包装器，将协同程序函数转换为一个可直接调用的函数对象
co = coroutine.wrap(
    function(i)
        print(i);
    end
)
 
co(1)
 
print("----------")
-- 创建了另一个协同程序对象 co2，其中的协同程序函数通过循环打印数字 1 到 10，在循环到 3 的时候输出当前协同程序的状态和正在运行的线程
co2 = coroutine.create(
    function()
        for i=1,10 do
            print(i)
            if i == 3 then
                print(coroutine.status(co2))  --running
                print(coroutine.running()) --thread:XXXXXX
            end
            coroutine.yield()
        end
    end
)

-- 连续调用 coroutine.resume 启动协同程序 co2 的执行
coroutine.resume(co2) --1
coroutine.resume(co2) --2
coroutine.resume(co2) --3

-- 通过 coroutine.status 检查协同程序 co2 的状态，输出为 suspended，表示协同程序暂停执行
print(coroutine.status(co2))   -- suspended
print(coroutine.running())
 
print("----------")


--[[
coroutine.running就可以看出来,coroutine在底层实现就是一个线程。
当create一个coroutine的时候就是在新线程中注册了一个事件。
当使用resume触发事件的时候，create的coroutine函数就被执行了，当遇到yield的时候就代表挂起当前线程，等候再次resume触发事件。 

--]]



function foo (a)
    print("foo 函数输出", a)
    return coroutine.yield(2 * a) -- 返回  2*a 的值
end
 
co = coroutine.create(function (a , b)
    print("第一次协同程序执行输出", a, b) -- co-body 1 10
    local r = foo(a + 1)
     
    print("第二次协同程序执行输出", r)
    local r, s = coroutine.yield(a + b, a - b)  -- a，b的值为第一次调用协同程序时传入
     
    print("第三次协同程序执行输出", r, s)
    return b, "结束协同程序"                   -- b的值为第二次调用协同程序时传入
end)
       
print("main", coroutine.resume(co, 1, 10)) -- true, 4
print("--分割线----")
print("main", coroutine.resume(co, "r")) -- true 11 -9
print("---分割线---")
print("main", coroutine.resume(co, "x", "y")) -- true 10 end
print("---分割线---")
print("main", coroutine.resume(co, "x", "y")) -- cannot resume dead coroutine
print("---分割线---")

--[[
以上实例接下如下：

    调用resume，将协同程序唤醒,resume操作成功返回true，否则返回false；
    协同程序运行；
    运行到yield语句；
    yield挂起协同程序，第一次resume返回；（注意：此处yield返回，参数是resume的参数）
    第二次resume，再次唤醒协同程序；（注意：此处resume的参数中，除了第一个参数，剩下的参数将作为yield的参数）
    yield返回；
    协同程序继续运行；
    如果使用的协同程序继续运行完成后继续调用 resume方法则输出：cannot resume dead coroutine

resume和yield的配合强大之处在于，resume处于主程中，它将外部状态（数据）传入到协同程序内部；而yield则将内部的状态（数据）返回到主程中。

--]]





























