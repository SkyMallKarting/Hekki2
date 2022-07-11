using Microsoft.Office.Interop.Excel;
using Hekki;
namespace ExcelWorker.Test
{
    public class WriteUsedKartsTests
    {
        private static Application excel = Hekki.ExcelWorker.GetExcel();
        [Test]
        public void WriteUsedKartsTest()
        {
            var pilots = new List<Pilot>() 
            { 
                new Pilot("Test1"),
                new Pilot("Test2"),
                new Pilot("Test3")
            };
            for (int i = 0; i < pilots.Count; i++)
            {

                pilots[i].AddNumberKart(i + 1, 0);
            }

        }
    }
}
