class Contact
{
    public string Name { get; set; }
    public String Phone { get; set; }
}



class ContactList
{

    public static List<Contact> contacts = new List<Contact>() {
        new Contact() { Name = "Amal shalayel", Phone = "00112233" }
        ,new Contact() { Name = "Amal Fadel", Phone = "00112244" }
        ,new Contact() { Name = "Sara Ahmed", Phone = "00110011" }
        ,new Contact() { Name = "Ahmed", Phone = "05741222" }
    };


    public static List<Contact> SearchByNameOrPhone(string keyword)
    {
        return contacts.Where(x => x.Name.Contains(keyword) || x.Phone.Contains(keyword)).ToList();
    }
}
