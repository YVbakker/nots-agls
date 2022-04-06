using api.Model;

namespace api.Services;

public interface IGitCommitService
{
    Task<List<GitCommit>> Get(int repoId);
    Task Create(IEnumerable<GitCommit> commits);
    Task Delete(int id);
}