using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Tests
{
    [TestClass()]
    public class CSVfileHandlerTests
    {
        [TestMethod()]
        public void inputStreamTest()
        {
            List<Stock> fileContent_valid, fileContent_not_valid;

            string location_valid = @"C:\Users\celes\Documents\Fall2016\oo\CS5700_hw2\Assign2\CompanyListTest.csv";
            string location_not_valid = @"C:\Users\celes\Documents\Fall2016\oo\CS5700_hw2\CompanyList.csv";

            CSVfileHandler handler = new CSVfileHandler();

            fileContent_valid = handler.inputStream(location_valid);
            fileContent_not_valid = handler.inputStream(location_not_valid);

            Assert.AreEqual(fileContent_valid.Count, 17);
            Assert.AreEqual(fileContent_not_valid, null);
        }
    }
}