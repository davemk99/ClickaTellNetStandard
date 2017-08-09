using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Clickatell_Service;

namespace ClickatellNetStandardTest
{
    [TestClass]
    public class ClickatellNetStandardTest
    {
        [TestMethod]
        public void TestClickatell()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("to", "+37455844741");
            dic.Add("content", "Hello beautiful world");
            var result=Api.SendSMS("1LiqWV2aThudgToVx-3YzA==",dic).Result;
        }
    }
}
