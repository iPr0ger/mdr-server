using mdr_server.Entities.Common;
using Nest;

namespace mdr_server.Entities.Object
{
    public class ObjectTopic
    {
        [Number(Name = "id")]
        #nullable enable
        public int? Id { get; set; }
        
        [Object]
        [PropertyName("topic_type")]
        #nullable enable
        public TopicType? TopicType { get; set; }
        
        [Boolean(Name = "mesh_coded")]
        #nullable enable
        public bool? MeshCoded { get; set; }
        
        [Text(Name = "mesh_code")]
        #nullable enable
        public string? MeshCode { get; set; }
        
        [Text(Name = "mesh_value")]
        #nullable enable
        public string? MeshValue { get; set; }

        [Text(Name = "original_value")]
        #nullable enable
        public string? OriginalValue { get; set; }
    }
}