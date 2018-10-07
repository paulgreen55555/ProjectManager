using ProjectManager.BusinessLogic.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectManager.Test
{
    [TestClass]
    public class ProjectServiceTest
    {
        [TestMethod]
        public void FirstTest()
        {
            Project project = new Project();
            Assert.AreEqual(project, project);
        }
    }
}
