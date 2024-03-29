﻿using Casgem_PortfolioCodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Casgem_PortfolioCodeFirstProject.DAL.Context
{
    public class TravelContext : DbContext
    {

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<About> Abouts { get; set; }

        public DbSet<Feature> Features { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }

        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Travel> Travels { get; set; }


    }
}