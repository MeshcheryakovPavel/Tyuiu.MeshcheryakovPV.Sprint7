using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Diagnostics;
using Tyuiu.MescheryakovPV.Sprint7.V6.Lib;

namespace Tyuiu.MescheryakovPV.Sprint7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetData_Test()
        {
            DataService.path = $@"\\Mac\Home\Desktop\testM.csv";

            DataTable dt = DataService.GetData();

            string[] con = { null, "&", null, "&", "&", "&", "&", };

            DataService.ChangeData("1", con);
        }
    }
}