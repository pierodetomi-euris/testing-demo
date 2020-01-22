using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingDemo.Models;

namespace TestingDemo.UnitTests
{
    [TestClass]
    public class CodeGeneratorServiceTest
    {
        /*
         
         * Input vuoto
         * Input whitespace
         * Input troppo corto
         * (non sussiste) Input troppo lungo
         * Prima lettera vocale
         * Prima lettera NON vocale
         * Terza lettera vocale
         * Terza lettera NON vocale
         * Lunghezza input pari
         * Lunghezza input dispari
         * 
         */


        // Input null
        [TestMethod]
        public void GenerateCode_InputIsEmpty_NotSuccessful()
        {
            #region Arrange

            string input = null;

            #endregion

            #region Act

            CodeGeneratorService service = new CodeGeneratorService { };
            CodeGenerationResult result = service.GenerateCode(input);

            #endregion

            #region Assert

            Assert.IsNotNull(result);
            Assert.IsFalse(result.IsSuccessful);
            Assert.IsNotNull(result.Error);
            Assert.IsTrue(result.Error.ToLower().Contains("empty"));
            Assert.IsNull(result.Code);

            #endregion
        }
    }
}