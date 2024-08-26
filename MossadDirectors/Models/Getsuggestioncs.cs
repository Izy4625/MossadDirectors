namespace MossadDirectors.Models
{
    public class Getsuggestioncs
    {
        public int MissionId { get; set; }
        public string? TargetName { get; set; }
        public string? TargetNotes { get; set; }
        public string? Targetlocation { get; set; }
        public string? AgentNickname { get; set; }
        public string? AgentLocation { get; set; }
        public double? Timeleft { get; set; }
        public double? DistanceBetween { get; set; }
    }
}
