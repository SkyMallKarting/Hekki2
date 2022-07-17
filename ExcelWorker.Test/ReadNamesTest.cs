using Microsoft.Office.Interop.Excel;
namespace ExcelWorker.Test
{
    [TestFixture]
    public class ReadNamesTests
    {   
        private List<string> namesOriginal;
        private List<string> testNames;

        [SetUp]
        public void Setup()
        {
            namesOriginal = Hekki.ExcelWorker.ReadNamesInTotalBoard();
            testNames = Hekki.ExcelWorker.ReadTestNamesFromTxt();
            Hekki.ExcelWorker.WriteNamesInTotalBoard(testNames);
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            Hekki.ExcelWorker.WriteNamesInTotalBoard(namesOriginal);
        }

        [Test]
        public void ReturnedNamesIsExpected()
        {
            var names = Hekki.ExcelWorker.ReadNamesInTotalBoard();

            for (int i = 0; i < testNames.Count; i++)
            {
                Assert.AreEqual(testNames[i], names[i]);
            }
        }

        [Test]
        public void NamesLengthMoreZero()
        {
            var names = Hekki.ExcelWorker.ReadNamesInTotalBoard();

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