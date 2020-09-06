using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalPage.Persistence.Models
{
    public abstract class BaseEntity
    {
        public ObjectId Id { get; set; }
    }
}
