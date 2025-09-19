namespace FinalOOProject.Services
{
	public interface IService<T>
    {
		/* 
         * Framework to create a new IService interface
         * Author: James
         */

        // List of reserved functions to be implemented in descendent objects
		Task<bool> AddUpdateXAsync(T var);
        Task<bool> DeleteXAsync(int var);
        Task<T> GetXAsync(int var);
        Task<IEnumerable<T>> GetXAsync();
    }
}
