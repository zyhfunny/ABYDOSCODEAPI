# ABYDOSCODEAPI

***ʹ��ba�а��ݶ�˹���»��Ա�������������ַ���***

## 1. API�����ʽ

**1.1����**

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

**1.2����**

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

**ע�⣺�뽫����<your_ip>�滻Ϊ�㲿��api�ķ�����ip��ַ(����ip:127.0.0.1)��<your_input>�滻Ϊ����Ҫ�������ַ�����<your_key>�滻Ϊkey(�����޸ļ��㷽ʽ)��keyĬ�ϼ��㷽����**

```python
from datetime import datetime
math.floor(int((datetime.now() - datetime(1970, 1, 1)).total_seconds())+math.sqrt(int((datetime.now() - datetime(1970, 1, 1)).total_seconds())))
```

## β��

**��ֻ��һ��*������*�����ܳ�����~~����~~���⣬����в����������ָ��������Ҫ����**
