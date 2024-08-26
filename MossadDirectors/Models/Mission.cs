
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MossadDirectors.Enum;
namespace MossadDirectors.Models
{
    public class Mission
    {
        
        public int Id { get; set; }
     
        public int AgentId { get; set; }
   
        public int TargetId { get; set; }

        public double? MissionTimer { get; set; }
        
        public EnumSatusMissions Status { get; set; }

    }
}
