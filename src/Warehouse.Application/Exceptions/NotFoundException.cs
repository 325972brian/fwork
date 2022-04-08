namespace Warehouse.Application.Exceptions
{
    /// <summary>
    /// Not found exception.
    /// </summary>
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key) : base($"Entity\"{name}\"({key}) was not found.") { }
    }
}
