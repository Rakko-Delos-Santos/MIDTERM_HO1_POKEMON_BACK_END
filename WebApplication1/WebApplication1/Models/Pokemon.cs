using System.Collections.Generic;
namespace WebApplication1.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Types { get; set; }
        public int Generation { get; set; }
        public int? NextEvolutionId { get; set; }  
        public int? BaseEvolutionId { get; set; }  
        public string ImageUrl { get; set; }

        // Add these new properties
        public int Height { get; set; }  // In decimeters (10 = 1 meter)
        public int Weight { get; set; }  // In hectograms (10 = 1 kg)
    }
}