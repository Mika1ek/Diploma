﻿using Allure.Net.Commons;
using Diploma.Models;
using Newtonsoft.Json;
using NLog;
using System.Net;


namespace Diploma.Tests.APITests
{
    public class GetTests : BaseApiTest
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        [Test]
        [Category("NFE")]
        public void GetMilestoneTest()
        {  
            var actualMilestone = MilestoneService!.GetMilestone("2");

            Assert.That(actualMilestone, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        [Category("NFE")]
        public void GetAllMilestoneTest()
        {
            var result = MilestoneService!.GetAllMilestone("31");
            _logger.Info(result);

            Assert.Multiple(() =>
            {
                Assert.That(result.Result.Page, Is.EqualTo(1));
                Assert.That(result.Result.PerPage, Is.EqualTo(100));
                Assert.That(result.Result.Total, Is.EqualTo(2));
                //Assert.That(result.Result.Total, Is.EqualTo(result.Result.Length));
            });
        }

        [Test]
        [Category("NFE")]
        public void GetAllProjectsTest()
        {
            var allProjects = ProjectService!.GetProjects();

            Assert.Multiple(() =>
            {
                Assert.That(allProjects.Result.Page, Is.EqualTo(1));
                Assert.That(allProjects.Result.Total, Is.EqualTo(7));
            });
        }

        /*[Test]
        [Category("NFE")]
        public void GetAllAutomationRunsTest()
        {
            var autoRun_project = ProjectService!.GetAllAutomationRun().Result;

            Assert.Multiple(() =>
            {
                Assert.That(autoRun_project.Page, Is.EqualTo(1));
                Assert.That(autoRun_project.Last_page, Is.EqualTo(1));
            });
        }*/

        [Test]
        [Category("AFE")]
        public void GetIncorrectUser()
        {
            var incorrectUser = ProjectService!.GetInvalidUser();
            Assert.That(incorrectUser.Result.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
            ErrorResponse invalid = JsonConvert.DeserializeObject<ErrorResponse>(incorrectUser.Result.Content);
            Assert.Multiple(() =>
            {
                Assert.That(invalid.Message, Is.EqualTo("The user does not exist or was disabled."));
                Assert.That(invalid.Сode, Is.EqualTo(0));
            });

            AllureApi.Step("Получена ожидаемая ошибка");
        }

        [Test]
        [Category("AFE")]
        public void GetIncorrectProject()
        {
            var incorrectProject = ProjectService!.GetInvalidProject();
            Assert.That(incorrectProject.Result.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
            ErrorResponse invalid = JsonConvert.DeserializeObject<ErrorResponse>(incorrectProject.Result.Content);
            Assert.Multiple(() =>
            {
                Assert.That(invalid.Message, Is.EqualTo("The project does not exist or you do not have the permissions to access it."));
                Assert.That(invalid.Сode, Is.EqualTo(0));
            });

            AllureApi.Step("Получена ожидаемая ошибка");
        }
    }
 }