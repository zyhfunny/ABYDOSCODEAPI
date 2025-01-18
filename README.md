# ABYDOSCODEAPI

***ʹ��ba�а��ݶ�˹���»��Ա�������������ַ���***

---

## 1. API�����ʽ

**1.1 ����**

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

**1.2 ����**

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

**ע�⣺�뽫����<your_ip>�滻Ϊ�㲿��api�ķ�����ip��ַ(����ip:127.0.0.1)��<your_input>�滻Ϊ����Ҫ�������ַ�����<your_key>�滻Ϊkey(�����޸ļ��㷽ʽ)**<br>
**Ĭ��key���㷽ʽ��**

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

## 2. ��ʾվ��

**��û����qwq**

---

## 3. β��

**��ֻ��һ��*������*�����ܳ�����~~����~~���⣬����в����������ָ��������Ҫ����**<br>
**��л[@hcymc](https://github.com/hcymc)�ṩ��ǰ�˴���֧��(��Ȼ��û�ϴ�)**
