namespace SimpleApp
{

    public class Contact
    {
        public string Name { get; set; }
        public String Phone { get; set; }
    }

    public class Exersice3
    {
        private static List<Contact> data = new List<Contact>() {
         new Contact() { Name = "Amal shalayel", Phone = "00112233" }
        ,new Contact() { Name = "Amal Fadel", Phone = "00112244" }
        ,new Contact() { Name = "Sara Ahmed", Phone = "00110011" }
        ,new Contact() { Name = "Ahmed", Phone = "05741222" }
        };


        public static Boolean SearchByNameOrPhone(string keyword)
        {


            var isExist =  data.Count(x => x.Name.Contains(keyword) || x.Phone.Contains(keyword)) ;

            if (isExist > 0)   
                return true;

            return false; 
        }
    }
}