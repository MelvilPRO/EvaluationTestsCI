using System.Data;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public sealed class HtmlFormatHelperUnitTest
    {
        private HtmlFormatHelper _htmlFormatHelper;
        [TestInitialize]
        public void Init()
        {
            _htmlFormatHelper = new HtmlFormatHelper();
        }


        [TestMethod]
        [DataRow("AAAA")]
        public void GetBoldFormat_RandomString_ReturnCorrectHtmlFormat(string content)
        {
            string result = _htmlFormatHelper.GetBoldFormat(content);
            
            Assert.AreEqual(result, "<b>AAAA</b>");
        }

        [TestMethod]
        [DataRow("BBBB")]
        public void GetItalicFormat_RandomString_ReturnCorrectHtmlFormat(string content)
        {
            string result = _htmlFormatHelper.GetItalicFormat(content);

            Assert.AreEqual(result, "<i>BBBB</i>");
        }

        //GetFormattedListElements

        [TestMethod]
        public void GetItalicFormat_RandomStrings_ReturnCorrectHtmlFormat()
        {
            List<string> contents = new List<string> { "Yes", "No" };

            string result = _htmlFormatHelper.GetFormattedListElements(contents);

            Assert.AreEqual(result, "<ul><li>Yes</li><li>No</li></ul>");
        }

        public void GetItalicFormat_EmptyStrings_ReturnCorrectHtmlFormat()
        {
            List<string> contents = new List<string> { "Yes", "No" };

            string result = _htmlFormatHelper.GetFormattedListElements(contents);

            Assert.AreEqual(result, "<ul></ul>");
        }
    }
}
