using System;
using System.Collections;
using System.IO;
using NUnit.Framework;
using sTextEditor.Services;

namespace sTextEditor.Tests.Services
{
    [TestFixture]
    public class FormattingServiceTest
    {
        [Test]
        [TestCaseSource(typeof(FormattingServiceDataFactory), "SampleJsonData")]
        public void CorrectJsonFormattingTest(string unformattedText, string formattedText)
        {
            var formattingService = new FormattingService();
            var serviceFormattedText = formattingService.FormatAsJson(unformattedText);

            Assert.AreEqual(serviceFormattedText, formattedText);
        }

        [Test]
        [TestCaseSource(typeof(FormattingServiceDataFactory), "SampleXmlData")]
        public void CorrectXmlFormattingTest(string unformattedText, string formattedText)
        {
            var formattingService = new FormattingService();
            var serviceFormattedText = formattingService.FormatAsXml(unformattedText);

            Assert.AreEqual(serviceFormattedText, formattedText);
        }
    }

    public class FormattingServiceDataFactory
    {
        public static IEnumerable SampleJsonData
        {
            get
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

                yield return new TestCaseData(
                    File.ReadAllText(Path.Combine(currentDirectory, "SampleData/unformatted.json")), 
                    File.ReadAllText(Path.Combine(currentDirectory, "SampleData/formatted.json")));
            }
        }

        public static IEnumerable SampleXmlData
        {
            get
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

                yield return new TestCaseData(
                    File.ReadAllText(Path.Combine(currentDirectory, "SampleData/unformatted.xml")),
                    File.ReadAllText(Path.Combine(currentDirectory, "SampleData/formatted.xml")));
            }
        }
    }
}
