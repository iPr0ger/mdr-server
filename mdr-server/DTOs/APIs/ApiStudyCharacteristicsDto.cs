namespace mdr_server.DTOs.APIs
{
    public class ApiStudyCharacteristicsDto : ApiBaseQueryDto
    {
        public string TitleContains { get; set; }
        public string LogicalOperator { get; set; }
        public string TopicsInclude { get; set; }
    }
}