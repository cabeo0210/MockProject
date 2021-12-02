using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Models;
using App.Models.Bookings;
using BookingModel = App.Models.Bookings.Booking;
namespace App.Repository.IBooking
{
    interface IBooking
    {
        void InsertBookingRecord(BookingModel Booking);
        IEnumerable<BookingModel> GetBookings();
        void UpdateBookingRecord(BookingModel Booking);
        void DeleteBookingRecord(int id);
        BookingModel GetBookingById(int id);
    }


}