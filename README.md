## GameTemplate

# 游戏基础框架，包含lua热更，mvc，skynet服务器

# 编译及安装

## 编译依赖
### 3rd/openssl 
[参考文档](https://wiki.openssl.org/index.php/Compilation_and_Installation)。  

对于64linux系统，可尝试用命令 "./Configure linux-x86_64 no-shared -fPIC; make"进行编译。   
* 对于32位系统，执行 "./config 386"   
* make && make install

### 3rd/skynet
make linux
[参考文档](https://github.com/cloudwu/skynet)。

## 安装
1. 先安装redis
2. 执行 tool/setup/setup 脚本，它会在项目根目录下创建一个var目录，创建好数据库需要的文件和管理脚本。

## 运行
1. 运行 var/redis-start 脚本，启动好对应的数据库实例。
2. cd some-mmorpg/server 
   make all 
3. 运行 server/run 脚本，启动服务器程序。