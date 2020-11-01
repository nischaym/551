using System;
using System.ComponentModel;

namespace Models
{
    public class Park
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Location")]
        public string Location { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Rank")]
        public int Rank { get; set; }

        [DisplayName("PhotoPath")]
        public string PhotoPath { get; set; }
    }
}
