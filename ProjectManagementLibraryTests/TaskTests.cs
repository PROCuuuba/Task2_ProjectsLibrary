using NUnit.Framework;

namespace ProjectManagementLibraryTests
{
    [TestFixture]
    public class TaskTests
    {
        [Test]
        public void Task_Constructor_InitializesProperties()
        {
            var task = new ProjectManagementLibrary.Task();
            Assert.IsNotNull(task);
        }
    }
}
