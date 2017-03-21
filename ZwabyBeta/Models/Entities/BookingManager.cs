using System;
using System.Collections.Generic;

namespace ZwabyBeta
{
	public class BookingManager
	{
		public static IList<Booking> Bookings
		{
			get;
			private set;
		}

		static BookingManager()
		{
			Bookings = new List<Booking>
			{
				new Booking
				{
					//CleanerName = "Carlos Lara",
					//BookingDate = DateTime.Parse("March 21, 2017"),
					//BookingTime = DateTime.Parse("00:08:30" + " AM"),
					////CleanerPhoto = 
					//ZwabyRating = "5 stars",
					//PublicRating = "5 stars" + " , " + "Angie's List",
					//ApproxDuration = "4 hours",
					//ApproxTotalCost = "100 USD"
				},

				new Booking
				{
					//CleanerName = "Paulette Wright",
					//BookingDate = DateTime.Parse("April 21, 2017"),
					//BookingTime = DateTime.Parse("00:13:30" + " PM"),
					////CleanerPhoto = 
					//ZwabyRating = "5 stars",
					//PublicRating = "5 stars" + " , " + "Angie's List",
					//ApproxDuration = "4 hours",
					//ApproxTotalCost = "120 USD"
				},

				new Booking
				{
					//CleanerName = "Margaret NY",
					//BookingDate = DateTime.Parse("May 21, 2017"),
					//BookingTime = DateTime.Parse("00:08:30" + " AM"),
					////CleanerPhoto = 
					//ZwabyRating = "5 stars",
					//PublicRating = "5 stars" + " , " + "Angie's List",
					//ApproxDuration = "4 hours",
					//ApproxTotalCost = "95 USD"
				},

				new Booking
				{
					//CleanerName = "Millenial Cleaner",
					//BookingDate = DateTime.Parse("June 21, 2017"),
					//BookingTime = DateTime.Parse("00:13:30" + " PM"),
					//CleanerPhoto = 
					//ZwabyRating = "5 stars",
					//PublicRating = "5 stars" + " , " + "Angie's List",
					//ApproxDuration = "3.5 hours",
					//ApproxTotalCost = "100 USD"
				}
			};


		}
	}
}

