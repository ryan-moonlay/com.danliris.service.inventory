﻿
using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.Danliris.Service.Inventory.Lib.Models
{
   public class FpReturProInvDocs : StandardEntity, IValidatableObject
    {
        public string Code { get; set; }
        public string NoBon { get; set; } 
        public string NoBonId { get; set; }
        public string UnitName { get; set; }
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Remark { get; set; }
        public string Operator { get; set; }
        public string MachineName { get; set; }
        public string MachineId { get; set; }
        public string MachineCode { get; set; }
        public string Shift { get; set; }
        public int AutoIncrementNumber { get; set; }
        public ICollection<FpRegradingResultDocsDetails> Details { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return new List<ValidationResult>();
        }
    }
}