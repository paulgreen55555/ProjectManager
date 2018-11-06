using ProjectManager.Entities.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectManager.Test
{
    [TestClass]
    public class ProjectServiceTest
    {
        [TestMethod]
        public void FirstTest()
        {
            ProjectDTO project = new ProjectDTO();
            Assert.AreEqual(project, project);
        }
    }
}
