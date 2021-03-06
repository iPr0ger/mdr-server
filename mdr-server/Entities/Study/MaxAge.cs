using Nest;

namespace mdr_server.Entities.Study
{
    public class MaxAge
    {
        [Number(Name = "value")]
        #nullable enable
        public int? Value { get; set; }
        
        [Number(Name = "unit_id")]
        #nullable enable
        public int? UnitId { get; set; }
        
        [Text(Name = "unit_name")]
        #nullable enable
        public string? UnitName { get; set; }
    }
}