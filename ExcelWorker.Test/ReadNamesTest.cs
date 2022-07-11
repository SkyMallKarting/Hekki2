using Microsoft.Office.Interop.Excel;
namespace ExcelWorker.Test
{
    [TestFixture]
    public class ReadNamesTests
    {
        private static Application excel = Hekki.ExcelWorker.GetExcel();
        private List<string> namesOriginal;

        [SetUp]
        public void Setup()
        {
            namesOriginal = Hekki.ExcelWorker.ReadNames(excel);
            var testNames = Hekki.ExcelWorker.ReadTestNamesFromTxt();
            Hekki.ExcelWorker.WriteNamesInTotalBoard(excel, testNames);
        }

        [TearDown]
        public void Cleanup()
        {
            Hekki.ExcelWorker.WriteNamesInTotalBoard(excel, namesOriginal);
        }

        [TestCase(new List<string>() { })]
        public void ReturnedNamesIsExpected(List<string> s)
        {
            

            var names = Hekki.ExcelWorker.ReadNames(excel);

            for (int i = 0; i < s.Count; i++)
            {
                Assert.AreEqual(s[i], names[i]);
            }
        }

        [Test]
        public void NamesLengthMoreZero()
        {

            var names = Hekki.ExcelWorker.ReadNames(excel);

            foreach (var name in names)
            {
                Assert.IsTrue(name.Length > 0);
            }
        }

        [Test]
        public void CorrectReadNamesFromTxt()
        {
            var names = new string[]
            {
                "MARTOLOG",
                "OLIFIRENKO",
                "ILLYAS",
                "KARLENKO",
                "KOPTYEV",
                "MARTYNENKO",
                "LAGODZYA",
                "BARANIUK",
                "BRAZHNIKOV",
                "VOLOSHYN",
                "KOVALCHUK",
                "YATSENKO",
                "SEMENEC",
                "RUDENKO",
                "FEDORCHUK M.",
                "KORDIK",
                "PORTYANKO",
                "DODONOV",
                "SHARAPOV",
                "MANAIENKO"
            };

            var readedNames = Hekki.ExcelWorker.ReadTestNamesFromTxt();

            for (int i = 0; i < names.Length; i++)
            {
                Assert.AreEqual(names[i], readedNames[i]);
            }
        }
    }
}