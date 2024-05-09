using Diploma.Models;
using RestSharp;
using System.Net;


namespace Diploma.Services;
public interface IProjectService
{
    Task<Projects> GetProjects();
    Task<RestResponse> GetInvalidUser();
    Task<RestResponse> GetInvalidProject();
    Task<Projects> GetAllAutomationRun();
    HttpStatusCode GetProject(Project project);
    HttpStatusCode PostAutomationRun(AutomationRun automationRun);
}
