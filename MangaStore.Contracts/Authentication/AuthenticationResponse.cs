using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaStore.Contracts.Authentication
{
    public record AuthenticationResponse(
        Guid Id,
        string LoginName,
        int Age,
        string Email,
        string Token
    );
}
