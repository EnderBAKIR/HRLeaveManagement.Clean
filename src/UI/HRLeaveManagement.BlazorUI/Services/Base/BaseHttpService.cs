using System.Net.Http.Headers;

namespace HRLeaveManagement.BlazorUI.Services.Base
{
    public class BaseHttpService
    {
        protected IClient _client;
  
        public BaseHttpService(IClient client)
        {
            _client = client;
            
        }

        

    }
}
