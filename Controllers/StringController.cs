using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeServicee.Data;

namespace EmployeeServicee.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StringController : ControllerBase
    {
        EmployeeServiceeContext _context;

        public object Name { get; private set; }

        public StringController(EmployeeServiceeContext context)
        {
            _context = context;
        }
        [HttpGet]
        public string Stringreverse(string s)

        {
            string result = string.Join(' ', s
                .Split(' ').
                Select(x => new string(x.Reverse().ToArray())));
            return result;
        }
        [HttpGet]
        public string Namingsplit(string name)
        {
            string first = name.Split(' ')[0];
            return first;
        }
        [HttpGet]
        public string convertname(string txt)
        {
            string txt1 = txt.ToUpper();
             return txt1;
        }
        [HttpGet]
        public int Length(string str)
        {
            int txt1 = str.Length;
            return txt1;
        }
        [HttpGet]
        public bool Comparing(string txt, string txt1)
        {
            if (string.Compare(txt, txt1) == 0)
            {
                return true;
            }

            else { }
            return false;
        }

    }
}
  

