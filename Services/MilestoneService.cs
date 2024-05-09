using Diploma.Clients;
using Diploma.Models;
using RestSharp;
using System.Net;

namespace Diploma.Services;

public class MilestoneService : IMilestoneService, IDisposable
{
    private readonly RestClientExtended _client;
    private readonly string milestoneId = "10";
    public MilestoneService(RestClientExtended client)
    {
        _client = client;
    }

    public HttpStatusCode GetMilestone(Milestone milestone)
    {
        var request = new RestRequest("/api/v1//milestones/{milestone_id}")
            .AddUrlSegment("milestone_id", milestoneId);

        return _client.ExecuteAsync(request).Result.StatusCode;
    }
    public void Dispose()
    {
        _client?.Dispose();
        GC.SuppressFinalize(this);
    }
}
