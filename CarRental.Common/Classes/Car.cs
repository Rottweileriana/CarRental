using CarRental.Common.Interfaces;
using CarRental.Common.Enums;
namespace CarRental.Common.Classes;

public class Car : IVehicle
{
    public Car(string RegNo, string Make, 
        int OdoMeter, double CostKm, 
        VehicleTypes VehicleType,
        int CostDay, VehicleStatuses VehicleStatus = default)
    {
        this.RegNo = RegNo;
        this.Make = Make;
        this.Odometer = OdoMeter;
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