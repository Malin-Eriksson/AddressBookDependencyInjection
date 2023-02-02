using AddressBookConsole.Interfaces;

namespace AddressBookConsole.Models;



internal class Contact : IContact
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

    internal static object Where(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }
}
