using Diploma.Clients;
using Diploma.Models;
using RestSharp;
using System.Net;

namespace Diploma.Services;

public class MilestoneService : IMilestoneService, IDisposable
{
    private readonly RestClientExtended _client;
    private readonly string milestoneId = "50";
    public MilestoneService(RestClientExtended client)
    {
        _client = client;
    }

    public HttpStatusCode GetMilestone(string milestoneId)
    {
        var request = new RestRequest("/api/v1/milestones/{milestone_id}")
            .AddUrlSegment("milestone_id", milestoneId);

        return _client.ExecuteAsync(request).Result.StatusCode;
    }

    public Task<Milestone> GetAllMilestone(string projectId)
    {
        var request = new RestRequest("/api/v1/projects/{project_id}/milestones")
            .AddUrlSegment("project_id", projectId);

        return _client.ExecuteAsync<Milestone>(request);
    }

    public void Dispose()
    {
        _client?.Dispose();
        GC.SuppressFinalize(this);
    }
}
