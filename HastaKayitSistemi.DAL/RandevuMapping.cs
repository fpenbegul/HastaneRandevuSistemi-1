﻿using HastaKayitSistemi.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DAL
{ 
    public class RandevuMapping : EntityTypeConfiguration<Randevu>
    {
        public RandevuMapping()

        { 
            HasKey(x => x.RandevuID);
            HasRequired(x => x.Doktor).WithMany(x => x.Randevular).HasForeignKey(x => x.RandevuID);
        }
    }
}
