using System;
using System.Collections.Generic;
using System.Text;

namespace Ntech.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
