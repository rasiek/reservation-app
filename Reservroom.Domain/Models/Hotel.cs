﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservroom.Domain.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;

        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }
        /// <summary>
        /// Get the reservations for a user 
        /// </summary>
        /// <param name="username">Username of the user</param>
        /// <returns>The reservations of the user</returns>
        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservationBook.GetReservationsForUser(username);
        }
        /// <summary>
        /// Make a Reservation
        /// </summary>
        /// <param name="reservation">The incoming reservation</param>
        /// <exception cref="ReservationConflictException"></exception>
        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }

    }
}
