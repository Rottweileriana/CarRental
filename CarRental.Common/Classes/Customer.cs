// Ignore Spelling: SSN

using CarRental.Common.Interfaces;
using System.Collections;

namespace CarRental.Common.Classes;

public class Costumer : IPerson
{
    public int SSN { get; set; }
    public string FirstName { get; set; } 
    public string LastName { get; set; }
   
    public Costumer(int SSN, string FirstName, string LastName) {
        this.SSN = SSN;
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
    
    /*public Customer GetPerson()
    {
        
    }*/

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
