using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreMVC3.Models
{
    [Bind(Exclude= "OrderId")]
    public partial class Order
    {
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        [ScaffoldColumn(false)]
        public string UserName { get; set; }

        [Required(ErrorMessage="Type in your First Name")]
        [DisplayName("First Name")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Type in your Last Name")]
        [DisplayName("Last Name")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Type in your Adress")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Type in your City")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "Type in your State")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "Type in your Postal Code")]
        [DisplayName("Postal Code")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Type in your Country")]
        [StringLength(40)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Type in your Phone Number")]
        [DisplayName("Phone Number")]
        [StringLength(24)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Type in your Email Adress")]
        [DisplayName("Email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage="Email is Not Valid.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}