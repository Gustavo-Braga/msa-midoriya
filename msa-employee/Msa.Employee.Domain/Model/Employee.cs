using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Msa.Employee.Domain.Model
{
    [BsonIgnoreExtraElements]
    public class Employee
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Skill { get; set; }
    }
}
