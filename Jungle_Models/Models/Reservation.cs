using System;
using System.Collections.Generic;

public class Reservation
{
    public Reservation()
    {
        [Key]
        public int Id { get; set; }

        //Nombre de places disponible pour le voyage
        public int NbPlaces { get; set; }

        //DateTravel = la date du voyage - la date de reservation(doit être supérieur ou égale à 14 jours)
        public DateTime DateTravel { get; set; }

        [Required]
        [MaxLength(10)]
        public int Numero { get; set; } 


        //Propriété de navigation 1 à plusieurs, côté 1
        public Travel? Travel { get; set; }
    }
}
