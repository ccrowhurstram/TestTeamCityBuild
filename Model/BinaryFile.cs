using System.ComponentModel.DataAnnotations;

namespace TestTeamCityBuild.Model
{
    public class BinaryFile
    {
        public int Id { get; set; }

        [MaxLength(40)]
        public string MediaType { get; set; }
    }
}