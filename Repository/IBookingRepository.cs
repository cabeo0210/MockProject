using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Models;
using App.Models.Bookings;
using Microsoft.EntityFrameworkCore;

namespace App.Repository.IBookingRepository
{
    public class IBookingRepository : App.Repository.IBooking.IBooking
    {
        private readonly AppDbContext _context;
        public IBookingRepository(AppDbContext context)
        {
            _context = context;
        }
        public AppDbContext context { get; set; }
        void IBooking.IBooking.DeleteBookingRecord(int id)
        {
            Booking booking = _context.Bookings.Find(id);
            _context.Bookings.Remove(booking);
            _context.SaveChanges();
        }

        Booking IBooking.IBooking.GetBookingById(int id)
        {
            return _context.Bookings.Find(id);
        }

        IEnumerable<Booking> IBooking.IBooking.GetBookings()
        {
            return _context.Bookings.ToList();
        }

        void IBooking.IBooking.InsertBookingRecord(Booking Booking)
        {
            _context.Bookings.Add(Booking);
            _context.SaveChanges();
        }

        void IBooking.IBooking.UpdateBookingRecord(Booking Booking)
        {
            _context.Entry(Booking).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }


}