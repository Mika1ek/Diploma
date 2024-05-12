using Diploma.Clients;
using Diploma.Models;
using RestSharp;
using System.Net;

namespace Diploma.Services;
public class ProjectService : IProjectService, IDisposable
{
    private readonly RestClientExtended _client;
    private readonly string projectId = "500";

    public ProjectService(RestClientExtended client)
    {
        _client = client;
    }

    public Task<Projects> GetAllProjects()
    {
        var request = new RestRequest("/api/v1/projects");

        return _client.ExecuteAsync<Projects>(request);
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
