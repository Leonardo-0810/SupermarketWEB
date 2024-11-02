﻿namespace SupermarketWEB.Models
{

    public class Paymode
        {

        public int Id { get; set; } // Será la llave primaria

        public string Name { get; set; }

        public string? Observation { get; set; }

        public ICollection<Paymode>? Paymodes { get; set; } = default!;// Propiedad de navegación
        }
}