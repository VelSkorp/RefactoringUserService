using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RefactoringUserService
{
	[ApiController]
	[Route("api/[controller]")]
	public class UsersController : ControllerBase
	{
		private readonly UsersStoreDbContext _context;
		private readonly ILogger<UsersController> _logger;

		public UsersController(UsersStoreDbContext context, ILogger<UsersController> logger)
		{
			_context = context;
			_logger = logger;
		}

		/// <summary>
		/// Deletes a user by id.
		/// </summary>
		/// <param name="id">The id of the user to delete.</param>
		/// <returns>Action result indicating the outcome of the delete operation.</returns>
		[HttpPost("delete/{id}")]
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> DeleteAsync(uint id)
		{
			var message = string.Empty;
			try
			{
				var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
				if (user is null)
				{
					message = $"User with id {id} not found.";
					_logger.LogWarning(message);
					return NotFound(message);
				}

				_context.Users.Remove(user);
				await _context.SaveChangesAsync();

				message = $"User with Login={user.Login} has been deleted.";
				_logger.LogInformation(message);
				return Ok(message);
			}
			catch (Exception ex)
			{
				message = "An error occurred while deleting the user.";
				_logger.LogError(ex, message);
				return StatusCode(500, message);
			}
		}
	}
}