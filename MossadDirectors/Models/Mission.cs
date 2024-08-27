
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MossadDirectors.Enum;
namespace MossadDirectors.Models
{
    public class Mission
    {
        
        public int Id { get; set; }
     
        public Agent agent { get; set; }
   
       public Target Target { get; set; }

        public double? MissionTimer { get; set; }
        
        public EnumSatusMissions Status { get; set; }

    }
}
