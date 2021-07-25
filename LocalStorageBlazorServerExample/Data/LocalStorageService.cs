using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Threading.Tasks;

namespace LocalStorageBlazorServerExample.Data
{
    public class LocalStorageService
    {
        private readonly ProtectedLocalStorage _protectedLocalStorage;

        public LocalStorageService(ProtectedLocalStorage protectedLocalStorage)
        {
            _protectedLocalStorage = protectedLocalStorage;
        }

        public async Task StoreValueAsync(string key, string value)
        {
            await _protectedLocalStorage.SetAsync("login", key, value);
        }
    }
}
