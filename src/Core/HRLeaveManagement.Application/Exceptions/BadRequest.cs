namespace HRLeaveManagement.Application.Exceptions
{
    public class BadRequest : Exception
    {
        public BadRequest(string message, object key) : base(message)
        {

        }
    }
}
