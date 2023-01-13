
using Proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Services
{
    public class LoginServices : ILoginRepository
    {
        public async Task<UserInfo> Login(string username, string password)
        {
            throw new NotImplementedException();
            /* try
            {
                if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
                {
                    var userInfo = new UserInfo();
                    var client = new HttpClient();
                   HttpRequestMessage response = await client.GetAsync("");
                    if(response.isSuccessStatusCode)
                    {
                        userInfo = await response.Content.ReadFromJsonAsync<UserInfo>();
                        return await Task.FromResult(userInfo);
                    }
                    else
                    {
                        return null;
                    }*/
        }
    }


}
