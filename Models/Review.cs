using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NetflixAndFriends_FinalProject_ENTPROG.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string ReviewContent { get; set; }

        public string MovieTitle { get; set; }


    }

    public enum ItemType
    {
        RawMaterials = 1,
        Intermediate = 2
    }

    
}




