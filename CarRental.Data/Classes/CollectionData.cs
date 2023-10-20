using CarRental.Common.Classes;
using CarRental.Common.Interfaces;
using CarRental.Common.Enums;
using CarRental.Data.Interfaces;

namespace CarRental.Data.Classes;

public class CollectionData : IData
{
    readonly List<IPerson> _persons = new List<IPerson>();
    readonly List<IVehicle> _vehicles = new List<IVehicle>();
    readonly List<IBooking> _bookings = new List<IBooking>();
    
    public CollectionData() => SeedData();

    void SeedData() {
        //Create lists, fake database
        _persons.Add(new Costumer(1234, "John", "Doe"));
        _persons.Add(new Costumer(5678, "Jane", "Doe"));
        _persons.Add(new Costumer(9012, "Alfred", "Hitchcock"));
        _vehicles.Add(new Car("ABC 123", "Volvo", 5000, 1.2, VehicleTypes.Sedan, 300, VehicleStatuses.Booked));
        _vehicles.Add(new Car("KBC 123", "Volvo", 4562, 1.2, VehicleTypes.SUV, 400, VehicleStatuses.Available));
        _vehicles.Add(new Car("PBC 123", "Volvo", 5957, 1.2, VehicleTypes.Sedan, 350, VehicleStatuses.Available));
        _vehicles.Add(new Car("AGC 123", "Volvo", 4793, 1.2, VehicleTypes.SUV, 240, VehicleStatuses.Available));
        _vehicles.Add(new Car("HBC 123", "Volvo", 7536, 1.2, VehicleTypes.Sedan, 200, VehicleStatuses.Available));
        _vehicles.Add(new Motorcycle("YBC 123", "Suzuki", 4463, 1.2, VehicleTypes.Motorcycle, 375, VehicleStatuses.Available));
        _bookings.Add(new Booking("ABC 123", "John Doe", 5000, null, "2/2/2023", null, null, VehicleStatuses.Booked));

    }


    public IEnumerable<IPerson> GetPersons() => _persons;
    public IEnumerable<IBooking> GetBookings() => _bookings;
    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default) => _vehicles;

    public IEnumerable<IBooking> writeBooking(string regNo, string name, int kmRented, int? kmReturned,string rented, string? returned, double? cost, VehicleStatuses status )
    {
        _bookings.Add(new Booking(regNo, name, kmRented, kmReturned,rented,returned, cost, status));
        return _bookings;
    }

}
