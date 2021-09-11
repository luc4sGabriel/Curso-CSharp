using System;
using Exceptions.Exceptions;

namespace Exceptions
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            Console.WriteLine(duration);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {

            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new ReservationException("Reservation dates for update must be future dates");
            }
            else if (checkOut <= checkIn)
            {
                throw new ReservationException("Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + "nights";
        }
    }
}
