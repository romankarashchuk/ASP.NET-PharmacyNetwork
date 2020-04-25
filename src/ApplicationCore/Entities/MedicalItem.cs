﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PharmacyNetwork.ApplicationCore.Entities
{
    public partial class MedicalItem
    {
        public MedicalItem()
        {
            Check = new HashSet<Check>();
            IncomeDetail = new HashSet<IncomeDetail>();
            PharmacyWharehouse = new HashSet<PharmacyWharehouse>();
        }

        public int MedItemId { get; set; }
        public int FirmId { get; set; }
        public int CategId { get; set; }
        [Display(Name = "Название")]
        public string MedItemName { get; set; }
        [Display(Name = "Описание")]
        public string MedItemDescrip { get; set; }
        public decimal MedItemPrice { get; set; }
        [Display(Name = "Цена")]
        public decimal? MedItemPriceMarkup { get; set; }

        public virtual ProductCategory Categ { get; set; }
        public virtual Firm Firm { get; set; }
        public virtual ICollection<Check> Check { get; set; }
        public virtual ICollection<IncomeDetail> IncomeDetail { get; set; }
        public virtual ICollection<PharmacyWharehouse> PharmacyWharehouse { get; set; }
    }
}
