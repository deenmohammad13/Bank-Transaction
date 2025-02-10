﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank__Transactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }


        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage ="This field is required")]
        [MaxLength(12,ErrorMessage ="Maximum charecter length is 12")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This field is required")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is required")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(11, ErrorMessage = "Maximum charecter length is 11")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public int Amount { get; set; }

        public DateTime Date {  get; set; }

    }
}
