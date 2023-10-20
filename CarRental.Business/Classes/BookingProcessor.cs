using CarRental.Common.Interfaces;
using CarRental.Common.Classes;
using CarRental.Data.Interfaces;
using CarRental.Common.Enums;

namespace CarRental.Business.Classes;

public class BookingProcessor
{
    private readonly IData _db;

    public BookingProcessor(IData db) => _db = db;
    public IEnumerable<Costumer> GetCostumers()
    {
            return _db.GetPersons().Cast<Costumer>();
    }
    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default) 
    {
            return _db.GetVehicles();

    }
    public IEnumerable<IBooking> GetBookings() {

        //how to make bookings?
        //IVehicle vehicle = _db.GetVehicles().First(reg => reg.RegNo == "ABC 123");
        //IPerson person = _db.GetPersons().First(name => name.FirstName == "John");
        
        //_db.writeBooking(vehicle.RegNo, person.FirstName + " " + person.LastName, vehicle.Odometer, null, DateTime.Today.ToString(), null, null, VehicleStatuses.Booked);

         return _db.GetBookings();
    }
}