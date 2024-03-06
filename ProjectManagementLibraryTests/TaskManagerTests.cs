using NUnit.Framework;
using ProjectManagementLibrary;

namespace ProjectManagementLibraryTests
{
    [TestFixture]
    public class TaskManagerTests
    {
        private TaskManager taskManager;

        [SetUp]
        public void Setup()
        {
            taskManager = new TaskManager();
        }

        [Test]
        public void TaskManager_AddTask_AddsTaskToList()
        {
            var task = new ProjectManagementLibrary.Task { Name = "Task 1" };
            taskManager.AddTask(1, task);
            Assert.Contains(task, taskManager.GetTasksForProject(1));
        }
    }
}
