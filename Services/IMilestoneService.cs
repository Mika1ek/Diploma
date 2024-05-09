using Diploma.Models;
using System.Net;
using RestSharp;

namespace Diploma.Services;

public interface IMilestoneService
{
    Task<Milestone> GetAllMilestone(string projectId);
    HttpStatusCode GetMilestone(string milestoneId);
}
