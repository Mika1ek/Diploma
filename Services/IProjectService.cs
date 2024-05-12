using Diploma.Models;
using RestSharp;
using System.Net;


namespace Diploma.Services;
public interface IProjectService
{
    Task<Projects> GetAllProjects();
    Task<RestResponse> GetInvalidUser();
    Task<RestResponse> GetInvalidProject();
} 
