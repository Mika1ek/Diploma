using Diploma.Clients;
using Diploma.Services;
using NLog;

namespace Diploma.Tests.APITests;

public class BaseApiTest
{
    protected ProjectService? ProjectService;
    protected MilestoneService? MilestoneService;
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();

    [OneTimeSetUp]
    public void SetupApi()
    {
        var restClient = new RestClientExtended();

        ProjectService = new ProjectService(restClient);

        MilestoneService = new MilestoneService(restClient);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        ProjectService?.Dispose();
        MilestoneService?.Dispose();
    }
}