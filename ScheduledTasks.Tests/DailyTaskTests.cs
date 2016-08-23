using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScheduledTasks.Tests
{
    [TestClass]
    public class DailyTaskTests
    {
        [TestMethod]
        public void DailyTaskCanBeCreated()
        {
            DailyTask task = new DailyTask();
        }
    }
}
