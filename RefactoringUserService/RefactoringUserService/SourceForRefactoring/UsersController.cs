using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace RefactoringUserService.Source
{
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly UsersStoreDbContext _context;

		public UsersController(UsersStoreDbContext context)
		{
			_context = context;
		}

		[HttpPost("delete/{id}")]
		public void Delete(uint id)
		{
			User user = _context.Users.FirstOrDefault(user => user.Id == id);
			_context.Users.Remove(user);
			_context.SaveChanges();
			Debug.WriteLine($"The user with Login={user.Login} has been deleted.");
			return Ok();
		}
	}
}