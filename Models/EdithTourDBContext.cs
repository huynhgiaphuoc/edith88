using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EdithTour.Models
{
    public partial class EdithTourDBContext : DbContext
    {
        public EdithTourDBContext()
            : base("name=EdithTourDBContext")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Airline> Airlines { get; set; }
        public virtual DbSet<Combo> Comboes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Customer_Level> Customer_Level { get; set; }
        public virtual DbSet<Data_market> Data_market { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<location> locations { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orderdetail> Orderdetails { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Ticket_Combo> Ticket_Combo { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<Tour_Inside> Tour_Inside { get; set; }
        public virtual DbSet<Tour_Outside> Tour_Outside { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Avatar)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Birthday)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.Air_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.Place_go)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.Place_leave)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.Time_go)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.Time_leave)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.Day_go)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.Day_leave)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.Ticket)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Airline>()
                .Property(e => e.Note_ticket)
                .IsUnicode(false);

            modelBuilder.Entity<Combo>()
                .Property(e => e.Combo_code)
                .IsUnicode(false);

            modelBuilder.Entity<Combo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Avatar)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Birthday)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Hotel_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<location>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<location>()
                .Property(e => e.location1)
                .IsUnicode(false);

            modelBuilder.Entity<location>()
                .Property(e => e.at)
                .IsUnicode(false);

            modelBuilder.Entity<location>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Cus_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.service_name)
                .IsUnicode(false);

            modelBuilder.Entity<Orderdetail>()
                .Property(e => e.Name_ticket)
                .IsUnicode(false);

            modelBuilder.Entity<Orderdetail>()
                .Property(e => e.Payment_method)
                .IsUnicode(false);

            modelBuilder.Entity<Orderdetail>()
                .Property(e => e.Numberof_ticket)
                .IsUnicode(false);

            modelBuilder.Entity<Orderdetail>()
                .Property(e => e.Total_price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.Res_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.Time_close)
                .IsUnicode(false);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.Menu)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.Room_code)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.Evaluate)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Schedule>()
                .Property(e => e.Start_time)
                .IsUnicode(false);

            modelBuilder.Entity<Schedule>()
                .Property(e => e.Day_begin)
                .IsUnicode(false);

            modelBuilder.Entity<Schedule>()
                .Property(e => e.End_time)
                .IsUnicode(false);

            modelBuilder.Entity<Schedule>()
                .Property(e => e.End_Day)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.Ticket_code)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket_Combo>()
                .Property(e => e.Ticket_combo_code)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket_Combo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Ticket_Combo>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ticket_Combo>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Tour>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Tour>()
                .Property(e => e.Tour_trending)
                .IsUnicode(false);

            modelBuilder.Entity<Tour_Inside>()
                .Property(e => e.Tour_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Tour_Inside>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Tour_Inside>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Tour_Inside>()
                .Property(e => e.Place)
                .IsUnicode(false);

            modelBuilder.Entity<Tour_Inside>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Tour_Inside>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Tour_Outside>()
                .Property(e => e.Tour_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Tour_Outside>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Tour_Outside>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Tour_Outside>()
                .Property(e => e.Place)
                .IsUnicode(false);

            modelBuilder.Entity<Tour_Outside>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Tour_Outside>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Tour_Outside>()
                .Property(e => e.Visa_support)
                .IsUnicode(false);

            modelBuilder.Entity<Tour_Outside>()
                .Property(e => e.Country_code)
                .IsUnicode(false);
        }
    }
}
