import mysql.connector

mydb = mysql.connector.connect(
  host = "localhost",       	# 数据库主机地址
  user = "goes",    			# 数据库用户名
  passwd = "goes",   		 	# 数据库密码
  database="python_db"
)

"""
注意：如果你的 MySQL 是 8.0 版本，密码插件验证方式发生了变化，早期版本为 mysql_native_password，8.0 版本为 caching_sha2_password，所以需要做些改变：

sudo vim /etc/mysql/mysql.conf.d/mysqld.cnf
在配置文件中找到[mysqld]部分，然后添加或修改以下行，以指定使用mysql_native_password插件：
[mysqld]
default_authentication_plugin=mysql_native_password

重启MySQL服务器以应用更改：
sudo service mysql restart

mysql -u root -p   # pw:czg...
ALTER USER 'goes'@'localhost' IDENTIFIED WITH 'mysql_native_password' BY 'goes';
FLUSH PRIVILEGES;
"""


# 创建数据库:创建数据库使用 "CREATE DATABASE" 语句
"""
mycursor = mydb.cursor()
mycursor.execute("CREATE DATABASE IF NOT EXISTS python_db")
mycursor.execute("SHOW DATABASES")
for x in mycursor:
  print(x)
"""


# 创建数据表:创建数据表使用 "CREATE TABLE" 语句，创建数据表前，需要确保数据库已存在
"""
mycursor = mydb.cursor()
mycursor.execute("CREATE TABLE IF NOT EXISTS sites (name VARCHAR(255), url VARCHAR(255))")
mycursor.execute("SHOW TABLES")
for x in mycursor:
  print(x)
"""


# 主键设置:创建表的时候我们一般都会设置一个主键（PRIMARY KEY），我们可以使用 "INT AUTO_INCREMENT PRIMARY KEY" 语句来创建一个主键，主键起始值为 1，逐步递增。
"""
mycursor = mydb.cursor()
# 如果你还未创建 sites 表
mycursor.execute("CREATE TABLE sites (id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(255), url VARCHAR(255))")
# 已经创建表
mycursor.execute("ALTER TABLE sites ADD COLUMN id INT AUTO_INCREMENT PRIMARY KEY")
"""
mycursor = mydb.cursor()
# 如果你还未创建 sites 表
mycursor.execute("CREATE TABLE IF NOT EXISTS sites (id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(255), url VARCHAR(255))")

print("------------")


# 插入数据:插入数据使用 "INSERT INTO" 语句
mycursor = mydb.cursor()
sql = "INSERT INTO sites (name, url) VALUES (%s, %s)"
val = ("RUNOOB", "https://www.runoob.com")
mycursor.execute(sql, val)
 
mydb.commit()    # 数据表内容有更新，必须使用到该语句
 
print(mycursor.rowcount, "记录插入成功。")

print("------------")


# 批量插入: 批量插入使用 executemany() 方法，该方法的第二个参数是一个元组列表
mycursor = mydb.cursor()
sql = "INSERT INTO sites (name, url) VALUES (%s, %s)"
val = [
  ('Google', 'https://www.google.com'),
  ('Github', 'https://www.github.com'),
  ('Taobao', 'https://www.taobao.com'),
  ('stackoverflow', 'https://www.stackoverflow.com/')
]

mycursor.executemany(sql, val)
mydb.commit()    # 数据表内容有更新，必须使用到该语句
print(mycursor.rowcount, "记录插入成功。")
# 关闭结果集
mycursor.close()

print("------------")


# 如果我们想在数据记录插入后，获取该记录的 ID
mycursor = mydb.cursor()
sql = "INSERT INTO sites (name, url) VALUES (%s, %s)"
val = ("Zhihu", "https://www.zhihu.com")
mycursor.execute(sql, val)
 
mydb.commit()
 
print("1 条记录已插入, ID:", mycursor.lastrowid)

# 关闭结果集
mycursor.close()


print("------------")

# 查询数据:查询数据使用 SELECT 语句：
mycursor = mydb.cursor()
mycursor.execute("SELECT * FROM sites")
myresult = mycursor.fetchall()     # fetchall() 获取所有记录
 
for x in myresult:
  print(x)

# 关闭结果集
mycursor.close()


print("------------")

# 读取指定的字段数据
mycursor = mydb.cursor()
mycursor.execute("SELECT name, url FROM sites")
myresult = mycursor.fetchall()
 
for x in myresult:
  print(x)

# 关闭结果集
mycursor.close()


print("------------")

"""
# 只想读取一条数据，可以使用 fetchone() 方法
mycursor = mydb.cursor()
mycursor.execute("SELECT * FROM sites")
myresult = mycursor.fetchone()
 
print(myresult)
# 关闭结果集
mycursor.close()

print("------------")
"""

# where 条件语句：读取指定条件的数据，可以使用 where 语句
mycursor = mydb.cursor()
sql = "SELECT * FROM sites WHERE name ='RUNOOB'"
mycursor.execute(sql)
myresult = mycursor.fetchall()
 
for x in myresult:
  print(x)
# 关闭结果集
mycursor.close()



print("------------")

# 使用通配符 %：
mycursor = mydb.cursor()
sql = "SELECT * FROM sites WHERE url LIKE '%oo%'"
mycursor.execute(sql)
myresult = mycursor.fetchall()
 
for x in myresult:
  print(x)
# 关闭结果集
mycursor.close()


print("------------")

# 为了防止数据库查询发生 SQL 注入的攻击，我们可以使用 %s 占位符来转义查询的条件：
mycursor = mydb.cursor()
sql = "SELECT * FROM sites WHERE name = %s"
na = ("RUNOOB", )
mycursor.execute(sql, na)
myresult = mycursor.fetchall()
 
for x in myresult:
  print(x)
# 关闭结果集
mycursor.close()

print("------------")


# 排序:查询结果排序可以使用 ORDER BY 语句，默认的排序方式为升序，关键字为 ASC，如果要设置降序排序，可以设置关键字 DESC。
mycursor = mydb.cursor()
sql = "SELECT * FROM sites ORDER BY name"
mycursor.execute(sql)
myresult = mycursor.fetchall()
 
for x in myresult:
  print(x)
# 关闭结果集
mycursor.close()

print("------------")

# 降序排序：
mycursor = mydb.cursor()
sql = "SELECT * FROM sites ORDER BY name DESC"
mycursor.execute(sql)
myresult = mycursor.fetchall()
 
for x in myresult:
  print(x)
# 关闭结果集
mycursor.close()


print("------------")

# Limit: 如果我们要设置查询的数据量，可以通过 "LIMIT" 语句来指定
mycursor = mydb.cursor()
mycursor.execute("SELECT * FROM sites LIMIT 3")
myresult = mycursor.fetchall()
 
for x in myresult:
  print(x)
# 关闭结果集
mycursor.close()


print("------------")


# 可以指定起始位置，使用的关键字是 OFFSET
mycursor = mydb.cursor()
mycursor.execute("SELECT * FROM sites LIMIT 3 OFFSET 1")  # 0 为 第一条，1 为第二条，以此类推
myresult = mycursor.fetchall()
 
for x in myresult:
  print(x)
# 关闭结果集
mycursor.close()


print("------------")

# 删除记录:删除记录使用 "DELETE FROM" 语句：
# 注意：要慎重使用删除语句，删除语句要确保指定了 WHERE 条件语句，否则会导致整表数据被删除。
mycursor = mydb.cursor()
sql = "DELETE FROM sites WHERE name = 'stackoverflow'"
mycursor.execute(sql)
mydb.commit()

print(mycursor.rowcount, " 条记录删除")
# 关闭结果集
mycursor.close()

print("------------")

# 为了防止数据库查询发生 SQL 注入的攻击，我们可以使用 %s 占位符来转义删除语句的条件：
mycursor = mydb.cursor()
sql = "DELETE FROM sites WHERE name = %s"
na = ("stackoverflow", )
mycursor.execute(sql, na)
mydb.commit()

print(mycursor.rowcount, " 条记录删除")
# 关闭结果集
mycursor.close()


print("------------")

# 更新表数据: 数据表更新使用 "UPDATE" 语句：
# 注意：UPDATE 语句要确保指定了 WHERE 条件语句，否则会导致整表数据被更新。
mycursor = mydb.cursor()
sql = "UPDATE sites SET name = 'ZH' WHERE name = 'Zhihu'"
mycursor.execute(sql)
mydb.commit()
 
print(mycursor.rowcount, " 条记录被修改")
# 关闭结果集
mycursor.close()


print("------------")

# 为了防止数据库查询发生 SQL 注入的攻击，我们可以使用 %s 占位符来转义更新语句的条件：
mycursor = mydb.cursor()
sql = "UPDATE sites SET name = %s WHERE name = %s"
val = ("Zhihu", "ZH")
mycursor.execute(sql, val)
mydb.commit()
 
print(mycursor.rowcount, " 条记录被修改")
# 关闭结果集
mycursor.close()


# 删除表:删除表使用 "DROP TABLE" 语句， IF EXISTS 关键字是用于判断表是否存在，只有在存在的情况才删除：
mycursor = mydb.cursor()
sql = "DROP TABLE IF EXISTS sites"  # 删除数据表 sites
mycursor.execute(sql)
# 关闭结果集
mycursor.close()















