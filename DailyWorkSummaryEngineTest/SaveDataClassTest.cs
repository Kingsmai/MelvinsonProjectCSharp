using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DailyWorkSummaryEngine.Models;

namespace DailyWorkSummaryEngineTest
{
    [TestClass]
    public class SaveDataClassTest
    {
        #region PrivateLogTest
        [TestMethod]
        public void PrivateLogAll()
        {
            SaveData saveData = new SaveData();
            saveData.Summary = "这里应该输出所有内容";
            saveData.Plan = "这是计划的内容";
            saveData.Note = "这些别人看不见的内容";
            Console.WriteLine(saveData.PrivateTextLog);
        }

        [TestMethod]
        public void PrivateLogWithSummaryAndPlan()
        {
            SaveData saveData = new SaveData();
            saveData.Summary = "这里只能看到总结和计划";
            saveData.Plan = "这是计划的内容";
            Console.WriteLine(saveData.PrivateTextLog);
        }

        [TestMethod]
        public void PrivateLogWithSummaryAndNote()
        {
            SaveData saveData = new SaveData();
            saveData.Summary = "这里能看到总结和笔记";
            saveData.Note = "这是别人看不见的内容";
            Console.WriteLine(saveData.PrivateTextLog);
        }

        [TestMethod]
        public void PrivateLogWithSummaryOnly()
        {
            SaveData saveData = new SaveData();
            saveData.Summary = "这里只有总结";
            Console.WriteLine(saveData.PrivateTextLog);
        }
        #endregion

        [TestMethod]
        public void PublicLogAll()
        {
            SaveData saveData = new SaveData();
            saveData.Summary = "这里应该输出所有内容";
            saveData.Plan = "这是计划的内容";
            saveData.Note = "这些别人看不见的内容";
            Console.WriteLine(saveData.PublicTextLog);
        }

        [TestMethod]
        public void PublicLogWithSummaryAndPlan()
        {
            SaveData saveData = new SaveData();
            saveData.Summary = "这里只能看到总结和计划";
            saveData.Plan = "这是计划的内容";
            Console.WriteLine(saveData.PublicTextLog);
        }

        [TestMethod]
        public void PublicLogWithSummaryAndNote()
        {
            SaveData saveData = new SaveData();
            saveData.Summary = "这里只能看到总结";
            saveData.Note = "这是别人看不见的内容";
            Console.WriteLine(saveData.PublicTextLog);
        }

        [TestMethod]
        public void PublicLogWithSummaryOnly()
        {
            SaveData saveData = new SaveData();
            saveData.Summary = "这里只有总结";
            Console.WriteLine(saveData.PublicTextLog);
        }
    }
}
