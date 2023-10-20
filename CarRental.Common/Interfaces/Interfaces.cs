// Ignore Spelling: SSN

using CarRental.Common.Enums;
namespace CarRental.Common.Interfaces;

public interface IPerson
{
    public int SSN { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public interface IVehicle
{
    public string RegNo { get; init; }
    public string Make { get; init; }
    public int Odometer { get; set; }
    public double CostKm { get; init; }
    public VehicleTypes VehicleType { get; init; }
    public int CostDay { get; init; }
    public VehicleStatuses VehicleStatus {  get; set; }
}

public interface IBooking
{
    public string RegNo { get; set; }
    public string Costumer { get; set; }
    public int KmRented { get; set; }
    public int? KmReturned { get; set; }
    public string Rented {  get; set; }
    public string? Returned { get; set; }
    public double? Cost { get; set; }
    public  VehicleStatuses VehicleStatus { get; set; }


}
