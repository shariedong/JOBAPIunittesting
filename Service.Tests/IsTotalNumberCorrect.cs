using System.Linq;
using JobsAPI.Repo;
using JobsAPI.Service;
using Xunit;

namespace Service.Tests
{
    public class IsTotalNumberCorrect
    {
        [Fact]
        public async void Test_IsTotalNumberCorrect()
        {
            JobRepo jobRepo = new JobRepo();
            int jobNumberFromJobRepo = jobRepo.GetJobs().Count();
            
            IJobService _jobService = new JobService(jobRepo);
            var jobList = await _jobService.GetJobs();
            int jobNumberFromJobService = jobList.Count();
            
            Assert.Equal(jobNumberFromJobRepo, jobNumberFromJobService);
        }
    }
}
