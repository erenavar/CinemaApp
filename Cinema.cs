using System;
namespace CinemaApp
{
	public class Cinema
	{
		public Cinema(int capacity,string nameOfFilm,int fullTicketPrice,int halfTicketPrice )
		{
			this.Capacity = capacity;
			this.PriceOfFullTicket = fullTicketPrice;
			this.PriceOfHalfTicket = halfTicketPrice;
			this.FilmName = nameOfFilm;
		}

        public string FilmName;
		public int Capacity;
		public int PriceOfFullTicket;
		public int PriceOfHalfTicket;
		public int TotalFullTicket;
		public int TotalHalfTicket;
		public int Ciro {
			get
			{
                return (PriceOfFullTicket * TotalFullTicket) + (PriceOfHalfTicket * TotalHalfTicket);
			}

				}

		public void updateTotalTickets(int fullTicket,int halfTicket)
		{
			this.TotalFullTicket += fullTicket;
			this.TotalHalfTicket += halfTicket;
			this.Capacity = this.Capacity-this.TotalFullTicket - this.TotalHalfTicket;
		}

	}
}

