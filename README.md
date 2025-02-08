# ABYDOSCODEAPI

***使用ba中阿拜多斯对策委员会成员的名称来加密字符串***

---

## 1. API请求格式

### 1.1 加密

**GET:**

```
GET /code?input=<your_input>&key=<your_key> HTTP/1.1
Host: <your_ip>:5000
```

**POST:**

```
POST /code HTTP/1.1
Host: <your_ip>:5000
Content-Type: application/json

{
    "Input": "<your_input>",
    "Key": <your_key>
}
```

### 1.2 解密

**GET:**

```
GET /decode?input=<your_input>&key=<your_key> HTTP/1.1
Host: <your_ip>:5000
```

**POST:**

```
POST /decode HTTP/1.1
Host: <your_ip>:5000
Content-Type: application/json

{
    "Input": "<your_input>",
    "Key": <your_key>
}
```
**注意：其中<your_ip>是你部署api的服务器的ip地址(本地ip:127.0.0.1)、<your_input>是你想要操作的字符串、<your_key>是你计算出的key(建议修改计算方式)**<br>
**默认key计算方式：**

**Python**

```python
from datetime import datetime
math.floor(int((datetime.now() - datetime(1970, 1, 1)).total_seconds())+math.sqrt(int((datetime.now() - datetime(1970, 1, 1)).total_seconds())))
```

**C#**

```csharp
Math.Floor(((int)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds) + Math.Sqrt(((int)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds)))
```

---
## 2. api响应格式
```json
{
    "result":"<string>"
}
```
### 示例(加密)：<br>
**请求(GET)：**<br>
```
http://localhost:5000/code?input=test&key=<your_key>
```
**响应：**
```json
{
    "result":"きいつシロコとにつノノミとユろいつシロコといつホシノとユきいつシロコといつノノミとユきいつシロコとにつノノミとユ"
}
```
---
## 3. 演示站点

[bacode.gohuo.fun](http://bacode.gohuo.fun)

---

## 4. 尾声

**这只是一个*初中生*无聊攒出来的~~弱智~~玩意，如果有不足或错误可以指出，但不要骂我**<br>
**感谢[@hcymc](https://github.com/hcymc)提供的前端代码支持**
