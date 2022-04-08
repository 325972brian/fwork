namespace Warehouse.Application.Exceptions
{
    /// <summary>
    /// Delete failure exception.
    /// </summary>
    public class DeleteFailureException : Exception
    {
        public DeleteFailureException(string name, object key, string message) : base($"Delete of entity\"{name}\"({key}) failed. {message}") { }
    }
}
