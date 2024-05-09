using Diploma.Models;
using System.Net;
using RestSharp;

namespace Diploma.Services;

public interface IMilestoneService
{
    HttpStatusCode GetMilestone(Milestone milestone);
}
