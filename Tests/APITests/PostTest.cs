using NLog;
using Diploma.Models;
using System.Net;


namespace Diploma.Tests.APITests
{
    public class PostTest : BaseApiTest
    {
        private AutomationRun _automationRun = new();
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        [Test]
        [Category("NFE_POST")]
        public void PostAutomationRunTest()
        {
            var totalCntAutomationRuns = ProjectService!.GetAllAutomationRun().Result.Total;   //получение значения перед выполнением POST 

            _automationRun = new AutomationRun
            {
                Name = "Test 1",
                Source = "backend"
            };

            var postAutomationRun = ProjectService!.PostAutomationRun(_automationRun);           //выполнение POST
            Assert.That(postAutomationRun, Is.EqualTo(HttpStatusCode.Created));
            var totalCntAutomationRunsUpd = ProjectService!.GetAllAutomationRun().Result.Total;  //получение значения после выполнением POST 
            Assert.That(++totalCntAutomationRuns, Is.EqualTo(totalCntAutomationRunsUpd));        //сравнение значений до и после
        }
    }
}