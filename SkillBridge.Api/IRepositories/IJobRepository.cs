public interface IJobRespository
{
    Task<IEnumerable<JobDto>> GetJobListAsync();
    Task<JobDto> GetJobByIdAsync(int id);
}