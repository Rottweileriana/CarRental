using CarRental.Common.Enums;
using CarRental.Common.Interfaces;



namespace CarRental.Data.Interfaces;

public interface IData
{
    IEnumerable<IPerson> GetPersons();
    IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default);
    IEnumerable<IBooking> GetBookings();

    IEnumerable<IBooking> writeBooking(string regNo, string name, int kmRented, int? kmReturned, string rented, string? returned, double? cost, VehicleStatuses status);

    /*
    IBooking GetBooking(int vehicleID);
    IPerson GetPerson(string socialSecuretyNumber);
    IPerson GetPerson(int id);
    IVehicle GetVehicle(string registrationNumber);
    IVehicle GetVehicle(int id);
    */
    /*
    
    */

}

/*class Vehicle : IVehicle
{
    string CustomerFirst { get; set; }
    string CustomerLast { get; set; }
    int CustomerSSN { get; set; }
    int kmRented { get; set; }
    int kmReturend { get; set; }

    List<Vehicle> vehicles = new();

    public List<Vehicle> Vehicles;

}
*/