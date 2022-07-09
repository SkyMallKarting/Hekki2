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
            //Assert.Pass();
        }

        
    }
}