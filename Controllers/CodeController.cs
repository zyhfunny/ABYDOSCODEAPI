using DecodeApi.Controllers;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;

namespace CodeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] string input, int? key = null)
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
                string result = Code(input);
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
                string result = Code(input);
                return Ok(new { result = result });
            }
            return BadRequest("Incorrect key");
        }
        private static readonly string[] n = new string[10] { "��", "��", "��", "��", "��", "��", "��", "��", "��", "��" };
        private static readonly Students[] s = new Students[5] {
            new Students("����", 6),
            new Students("�ۥ���", 5),
            new Students("�����", 4),
            new Students("���ꥫ", 3),
            new Students("�ΥΥ�", 1)
        };

        public struct Students
        {
            public string name;
            public int st;

            public Students(string x, int y)
            {
                name = x;
                st = y;
            }
        }

        private static string GetNum(int x)
        {
            string otp = "";
            while (x != 0)
            {
                otp += n[x % 10];
                x /= 10;
            }
            return otp + "��";
        }

        private static string Hc(int x)
        {
            string otp = "";
            for (int i = 0; i < 5; i++)
            {
                int num = x / s[i].st;
                x -= (num * s[i].st);
                if (num != 0) otp += GetNum(num) + s[i].name + "��";
            }
            return otp;
        }

        private static string Code(string x)
        {
            string otp = "";
            foreach (char c in x)
            {
                otp += Hc((int)c) + "��";
            }
            return otp;
        }
    }
}
