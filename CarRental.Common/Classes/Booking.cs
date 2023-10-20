using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;

public class Booking : IBooking
{
    public string RegNo { get; set; }
    public string Costumer { get; set; }
    public int KmRented { get; set; }
    public int? KmReturned { get; set; }
    public string Rented { get; set; }
    public string? Returned { get; set; }
    public double? Cost { get; set; }
    public VehicleStatuses VehicleStatus { get; set; }

    public Booking(string regNo, string costumer, int kmRented, int? kmReturned,string rented, string? returned, double? cost, VehicleStatuses vehicleStatus)
    {
        this.RegNo = regNo;
        this.Costumer = costumer;
        this.KmRented = kmRented;
        this.KmReturned = kmReturned;
        this.Rented = rented;
        this.Returned = returned;
        this.Cost = cost;
        this.VehicleStatus = vehicleStatus;
    }
}