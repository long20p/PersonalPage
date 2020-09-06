using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalPage.Persistence.Models
{
    public interface IIdentifiable<TId>
    {
        TId Id { get; }
    }
}
