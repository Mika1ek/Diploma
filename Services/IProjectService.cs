using Diploma.Models;
using RestSharp;
using System.Net;


namespace Diploma.Services;
public interface IProjectService
{
    Task<Projects> GetAllProjects();
    Task<RestResponse> GetInvalidUser();
    Task<RestResponse> GetInvalidProject();
<<<<<<< HEAD
} 
=======
    HttpStatusCode PostAutomationRun(AutomationRun automationRun);
    Task<Projects> GetAllAutomationRuns(string projectId);
}
>>>>>>> 6e2de829f21eda351d41e7431fe996f12ed481d1
