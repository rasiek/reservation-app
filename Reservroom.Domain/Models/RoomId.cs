using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservroom.Domain.Models
{
    public class RoomId
    {
        public int FloorNumber { get; }
        public int RoomNumber { get; }

        public RoomId(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
    
            return obj is RoomId roomId &&
                FloorNumber == roomId.FloorNumber &&
                RoomNumber == roomId.RoomNumber;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return HashCode.Combine(FloorNumber, RoomNumber);
        }
        

    }
}
