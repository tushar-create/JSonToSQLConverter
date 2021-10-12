using System;
using System.IO;
using JSonToSQLLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JSonToSQLLibraryMSTest
{
    [TestClass]
    public class JSonToSQLLibraryMSTest
    {
        [TestMethod]
        public void JsonToSQLConverter_InputJSon_ReturnSQLStatement()
        {
            JsonToSQLConverter jsonToSQLConverter = JsonToSQLConverter.Instance;
            string input = Directory.GetCurrentDirectory() + "\\Resources\\json.json";
            string json = File.ReadAllText(input);
            string sqlScript = jsonToSQLConverter.ToSQL(json);
            if(!string.IsNullOrEmpty(sqlScript))
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsFalse(true);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JsonToSQLConverter_InputNull_ReturnException()
        {
            JsonToSQLConverter jsonToSQLConverter = JsonToSQLConverter.Instance;
            string json = null;
            string sqlScript = jsonToSQLConverter.ToSQL(json);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JsonToSQLConverter_InputEmpty_ReturnException()
        {
            JsonToSQLConverter jsonToSQLConverter = JsonToSQLConverter.Instance;
            string json = string.Empty;
            string sqlScript = jsonToSQLConverter.ToSQL(json);
        }
    }
}
