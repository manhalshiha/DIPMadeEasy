using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDIPViolation
{
    public interface IAddress
    {
        string? Id { get; set; }
        string? StreetName { get; set; }
        string? StreetNumber { get; set; }
        string? ZipCode { get; set; }
        string? City { get; set; }
        string? Country { get; set; }

    }
}
