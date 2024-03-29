﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingDAL.Models
{
    [Table("branch")]
    public partial class branch
    {
        public branch()
        {
            rooms = new HashSet<room>();
        }

        [Key]
        public int branch_id { get; set; }
        [StringLength(50)]
        public string branch_name { get; set; }
        [StringLength(50)]
        public string branch_city { get; set; }
        [StringLength(50)]
        public string branch_country { get; set; }
        [JsonIgnore]
        [InverseProperty("branch")]
        public virtual ICollection<room> rooms { get; set; }
    }
}