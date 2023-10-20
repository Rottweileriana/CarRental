using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;

public class Motorcycle : IVehicle
{
    public Motorcycle(string RegNo, string Make,
       int Odometer, double CostKm,
       VehicleTypes VehicleType,
       int CostDay, VehicleStatuses VehicleStatus = default)
    {
        this.RegNo = RegNo;
        this.Make = Make;
        this.Odometer = Odometer;
        this.CostKm = CostKm;
        this.VehicleType = VehicleType;
        this.CostDay = CostDay; 
        this.VehicleStatus = VehicleStatus;
    }
    public string RegNo { get; init; }
    public string Make { get; init; }
    public int Odometer { get; set; }
    public double CostKm { get; init; }
    public VehicleTypes VehicleType { get; init; }
    public int CostDay { get; init; }
    public VehicleStatuses VehicleStatus { get; set; }
}
