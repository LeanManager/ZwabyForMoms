using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace ZwabyBeta
{
	public class Booking
	{
		// public event PropertyChangedEventHandler PropertyChanged;

		// Booking details to be shown in ListView at runtime upon ZwabyBeta.PaymentPage.BookNowEventHandler~:

		private string cleanerName;
		public string CleanerName
		{
			get { return cleanerName; }
			set { cleanerName = value; }
		}

		private DateTime bookingDate;
		public DateTime BookingDate
		{
			get { return bookingDate; }
			set { bookingDate = value; }
		}

		private DateTime bookingTime;
		public DateTime BookingTime
		{
			get { return bookingTime; }
			set { bookingTime = value; }
		}

		// Check this one to make sure it renders at runtime
		private Image cleanerPhoto;
		public Image CleanerPhoto
		{
			get { return cleanerPhoto; }
			set { cleanerPhoto = value; }
		}

		// Mmhmmm...
		private string zwabyRating;
		public string ZwabyRating
		{
			get { return zwabyRating; }
			set { zwabyRating = value; }
		}

		// Mmhmmm...
		private string publicRating;
		public string PublicRating
		{
			get { return publicRating; }
			set { publicRating = value; }
		}

		// This actually requires a function
		private string approxDuration;
		public string ApproxDuration
		{
			get { return approxDuration; }
			set { approxDuration = value; }
		}

		// This definitely requires a function(cleaning company)
		// e.g. string ApproxTotalCost = "100 USD";
		private string approxTotalCost;
		public string ApproxTotalCost
		{
			get { return approxTotalCost; }
			set { approxTotalCost = value; }
		}

		// ?
		// public string HeadshotUrl { get; set; }

		// overrride ToString() method?
		public override string ToString()
		{
			return this.bookingDate.ToString();
			//+ this.bookingTime.ToString();
		}

		//public Booking()
		//{
		//}
	}
}
