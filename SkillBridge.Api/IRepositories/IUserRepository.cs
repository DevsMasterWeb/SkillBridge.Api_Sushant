using SkillBridge.Api.Entities;

public interface IUserRepository 
{
    Task<string> CreateUserAsync(CreateUserRequestDto user);
}