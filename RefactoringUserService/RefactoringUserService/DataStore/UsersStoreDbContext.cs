using Microsoft.EntityFrameworkCore;

namespace RefactoringUserService
{
	/// <summary>
	/// The database context for the Users data store
	/// </summary>
	public class UsersStoreDbContext : DbContext
	{
		#region DbSets 

		/// <summary>
		/// Users data table
		/// </summary>
		public DbSet<User> Users { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public UsersStoreDbContext(DbContextOptions<UsersStoreDbContext> options) : base(options) { }

		#endregion

		#region Model Creating

		/// <summary>
		/// Configures the database structure and relationships
		/// </summary>
		/// <param name="modelBuilder"></param>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Fluent API

			// Configure
			// --------------------------
			//
			// Set primary keys
			modelBuilder.Entity<User>().HasKey(a => a.Id);
		}

		#endregion
	}
}