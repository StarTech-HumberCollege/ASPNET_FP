using System.ComponentModel.DataAnnotations;

namespace ASPNET_FP.Models
{
	public class Listing
	{
        // properties
        [Key]
        public int ListingId { get; set; }
		public int LandlordId { get; set; }
		public string HouseType { get; set; }
		public int AddressId { get; set; }
		public double TotalArea { get; set; }
		public int BedroomNo { get; set; }
		public int WahroomNo { get; set; }
		public int ParkingNo { get; set; }
		public string Description { get; set; }
		public double RentalPrice { get; set; }
		public DateTime ListingTime { get; set; }
		public int ValidDays { get; set; }
		public bool Status { get; set; }

		// constructor
		public Listing()
		{
		}
	}
}
