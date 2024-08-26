using MossadDirectors.Enum;
using System.ComponentModel.DataAnnotations;



namespace MossadDirectors.Models


{
    public class Agent
    {
       
        public int Id { get; set; }

        public string Nickname { get; set; }

        public string PhotoUrl { get; set; }
        public location? location { get; set; }

        public EnumSatusAgent? Status { get; set; }

    }
}
