using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDemo.Models
{
    public class CodeGenerationResult
    {
        public bool IsSuccessful { get; set; }

        public string Error { get; set; }

        public string Code { get; set; }
    }
}