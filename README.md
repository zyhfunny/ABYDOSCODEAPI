# ABYDOSCODEAPI

***使用ba中阿拜多斯理事会成员的名称来加密字符串***

## 1. API请求格式

**1.1加密**

**GET:**

```xml
GET /code?input=<your_input>&key=<your_key> HTTP/1.1
Host: <your_ip>:5000
```

**POST:**

```json
POST /code HTTP/1.1
Host: <your_ip>:5000
Content-Type: application/json

{
    "Input": "<your_input>",
    "Key": <your_key>
}
```

**1.2解密**

**GET:**

```xml
GET /decode?input=<your_input>&key=<your_key> HTTP/1.1
Host: <your_ip>:5000
```

**POST:**

```json
POST /decode HTTP/1.1
Host: <your_ip>:5000
Content-Type: application/json

{
    "Input": "<your_input>",
    "Key": <your_key>
}
```

**注意：请将其中<your_ip>替换为你部署api的服务器ip地址(本地ip:127.0.0.1)、<your_input>替换为你想要操作的字符串、<your_key>替换为key(建议修改计算方式)，key默认计算方法：**

```python
from datetime import datetime
math.floor(int((datetime.now() - datetime(1970, 1, 1)).total_seconds())+math.sqrt(int((datetime.now() - datetime(1970, 1, 1)).total_seconds())))
```

## 尾声

**这只是一个*初中生*无聊攒出来的~~弱智~~玩意，如果有不足或错误可以指出，但不要骂我**
