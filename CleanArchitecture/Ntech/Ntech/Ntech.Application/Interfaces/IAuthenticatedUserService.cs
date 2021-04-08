using System;
using System.Collections.Generic;
using System.Text;

namespace Ntech.Application.Interfaces
{
    public interface IAuthenticatedUserService
    {
        string UserId { get; }
    }
}
