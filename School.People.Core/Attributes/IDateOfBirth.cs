using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.People.Core.Attributes
{
    public interface IDateOfBirth : IAttribute
    {
        DateTimeOffset? Birthdate { get; }
    }
}
