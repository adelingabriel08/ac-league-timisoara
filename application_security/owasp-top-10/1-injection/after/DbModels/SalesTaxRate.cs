﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Injection.DbModels
{
    public partial class SalesTaxRate
    {
        public int SalesTaxRateId { get; set; }
        public int StateProvinceId { get; set; }
        public byte TaxType { get; set; }
        public decimal TaxRate { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual StateProvince StateProvince { get; set; }
    }
}
