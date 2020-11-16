using Newtonsoft.Json;
using System;

namespace JsonDB
{
    public interface IDbReference
    {
        Type EntityType { get; }
        int? ReferenceId { get; set; }
        [JsonIgnore]
        IDbEntity Entity { get; set; }
    }
}