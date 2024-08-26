using MossadDirectors.Enum;


namespace MossadDirectors.Models
{
    public class ViewAgentWithTarget
    {
      public Agent Agent { get; set; }
        public Target Target { get; set; }
        public Mission Mission { get; set; }
        public double? Distance { get; set; }
        public double? TimeOfExecution { get; set; }

    }
}
