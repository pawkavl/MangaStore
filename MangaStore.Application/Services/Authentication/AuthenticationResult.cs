using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaStore.Application.Services.Authentication
{
    public record AuthenticationResult
    (
        Guid Id,
        string LoginName,
        int Age,
        string Email,
        string Token
    );
}
