using Diploma.Clients;
using Diploma.Models;
using RestSharp;
using System.Net;

namespace Diploma.Services;
public class ProjectService : IProjectService, IDisposable
{
    private readonly RestClientExtended _client;
    private readonly string projectId = "50";

    public ProjectService(RestClientExtended client)
    {
        _client = client;
    }

    public HttpStatusCode GetProject(Project project)
    {
        var request = new RestRequest("/api/v1/projects/{project_id}")
            .AddUrlSegment("project_id", projectId);

        return _client.ExecuteAsync(request).Result.StatusCode;
    }

    public Task<Projects> GetProjects()
    {
        var request = new RestRequest("/api/v1/projects");

        var projects = _client.ExecuteAsync<Projects>(request);
        return projects;
    }

    public Task<Projects> GetAllAutomationRun()
    {
        var request = new RestRequest("/api/v1/projects/{project_id}/automation/runs")
            .AddUrlSegment("project_id", projectId);
        return _client.ExecuteAsync<Projects>(request);
    }

    public HttpStatusCode PostAutomationRun(AutomationRun automationRun)
    {
        var request = new RestRequest("/api/v1/projects/{project_id}/automation/runs", Method.Post)
           .AddUrlSegment("project_id", projectId)
            .AddJsonBody(automationRun);
        return _client.ExecuteAsync(request).Result.StatusCode;
    }

    public Task<RestResponse> GetInvalidUser()
    {
        var request = new RestRequest("/api/v1/users/2");
        return _client.ExecuteAsync(request);
    }

    public Task<RestResponse> GetInvalidProject()
    {
        var request = new RestRequest("/api/v1/projects/101");
        return _client.ExecuteAsync(request);
    }

    public void Dispose()
    {
        _client?.Dispose();
        GC.SuppressFinalize(this);
    }
}
