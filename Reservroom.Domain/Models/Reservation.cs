using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservroom.Domain.Models
{
    public class Reservation
    {
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }

        public string Username { get; }

        public RoomId RoomId { get; }

        public TimeSpan Length => EndTime.Subtract(StartTime);

        public Reservation(RoomId roomId, DateTime startTime, DateTime endTime, string username)
        {
            RoomId = roomId;
            StartTime = startTime;
            EndTime = endTime;
            Username = username;
        }

        public bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomId != RoomId)
            {
                return false;
            }

            return reservation.StartTime < EndTime && reservation.EndTime > StartTime;
        }
    }
}
