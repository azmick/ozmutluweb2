﻿using System.ComponentModel.DataAnnotations;

namespace ozmutluweb.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string Kullanici { get; set; }
        public string Sifre { get; set; }
    }
}
