using System;
using System.Collections.Generic;

public class Reservation
{
    public Reservation()
    {
        [Key]
        public int Id { get; set; }
        public int NbPlaces { get; set; }

    [Required]
    [MaxLength(25)]
    public string Name { get; set; } = string.Empty;


    //Propriété de navigation 1 à plusieurs, côté 1
    public Travel? Travel { get; set; }
}
}
