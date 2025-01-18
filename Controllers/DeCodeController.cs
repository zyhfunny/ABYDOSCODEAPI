using System;
using System.Collections.Generic;
using System.Linq;
using CodeApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DecodeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DecodeController : ControllerBase
    {
        private static char[] n = new char[10] { '��', '��', '��', '��', '��', '��', '��', '��', '��', '��' };
        [HttpGet]
        public ActionResult<string> Get([FromQuery] string input, int? key = null)
        {
            if (string.IsNullOrEmpty(input))
            {
                return BadRequest("Input is required.");
            }
            if (key == null)
            {
                return BadRequest("Key is null");
            }
            if (key == Math.Floor(((int)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds) + Math.Sqrt(((int)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds))))
            {
                string result = Decode(input);
                return Ok(new { result = result });
            }
            return BadRequest("Incorrect key");
        }
        [HttpPost]
        public IActionResult Post([FromBody] ABYDOSCODEAPI.Model model)
        {
            return ProcessRequest(model.Input, model.Key);
        }
        private IActionResult ProcessRequest(string input, int? key = null)
        {
            if (string.IsNullOrEmpty(input))
            {
                return BadRequest("Input is required.");
            }
            if (key == null)
            {
                return BadRequest("Key is null");
            }
            if (key == Math.Floor(((int)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds) + Math.Sqrt(((int)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds))))
            {
                string result = Decode(input);
                return Ok(new { result = result });
            }
            return BadRequest("Incorrect key");
        }
        private string to_num(string x)
        {
            string otp = "";
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (x[i] == n[j]) otp += j.ToString();
                }
            }
            return otp;
        }

        private string reverse(string x)
        {
            string otp = "";
            for (int i = x.Length - 1; i >= 0; i--)
            {
                otp += x[i].ToString();
            }
            return otp;
        }

        private string Decode(string x)
        {
            Queue<string> q = new Queue<string>();
            string otp = "", nt = "";
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != '��') nt += Convert.ToString(x[i]);
                if (x[i] == '��')
                {
                    q.Enqueue(nt);
                    nt = "";
                }
            }
            foreach (string s in q.ToArray())
            {
                string num = "", name = "";
                bool getnum = true, getname = false;
                int number = 0, text = 0;
                char ans;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != '��' && getnum) num += s[i].ToString();
                    if (s[i] != '��' && getname) name += s[i].ToString();
                    if (s[i] == '��')
                    {
                        getnum = false;
                        getname = true;
                        num = reverse(num);
                        num = to_num(num);
                        number = int.Parse(num);
                    }
                    if (s[i] == '��')
                    {
                        getnum = true;
                        getname = false;
                        switch (name)
                        {
                            case "����":
                                text += number * 6;
                                break;
                            case "�ۥ���":
                                text += number * 5;
                                break;
                            case "�����":
                                text += number * 4;
                                break;
                            case "���ꥫ":
                                text += number * 3;
                                break;
                            case "�ΥΥ�":
                                text += number * 1;
                                break;
                        }
                        num = "";
                        name = "";
                    }
                }
                ans = Convert.ToChar(text);
                otp += ans.ToString();
            }
            return otp;
        }
    }
}
