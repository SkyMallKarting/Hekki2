using Microsoft.Office.Interop.Excel;
namespace ExcelWorker.Test
{
    public class Tests
    {
        private static Application excel = Hekki.ExcelWorker.GetExcel();
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
        public void ReturnedNamesIsExpected()
        {
            // TODO: Сделать запись тестовых данных в конструкторе, а возврат оригинальных значений в деструкторе(?)
            var namesOriginal = Hekki.ExcelWorker.ReadNames(excel);
            var testNames = Hekki.ExcelWorker.ReadTestNamesFromTxt();
            Hekki.ExcelWorker.WriteNamesInTotalBoard(excel, testNames);

            var names = Hekki.ExcelWorker.ReadNames(excel);

            for (int i = 0; i < testNames.Count; i++)
            {
                Assert.AreEqual(testNames[i], names[i]);
            }

            Hekki.ExcelWorker.WriteNamesInTotalBoard(excel, namesOriginal);
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