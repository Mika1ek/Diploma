using Diploma.Models;
using RestSharp;
using System.Net;


namespace Diploma.Services;
public interface IProjectService
{
    Task<Projects> GetProjects(string projectId);
    Task<RestResponse> GetInvalidUser();
    Task<RestResponse> GetInvalidProject();
    /*Task<Projects> GetAllAutomationRun();
     * HttpStatusCode GetProject(Project project);*/
    HttpStatusCode PostAutomationRun(string automationRun);
}
