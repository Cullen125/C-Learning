namespace Pda
{
    public class Phone
    {
        public string PhoneNumber {  get; set; }
    }
    public interface IPerson
    {
        string FirstName { get; set; }
        string FamilyName { get; set; }
    }
    public class Contract : Phone,IPerson
    {
        public string Address { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }

        public Contract()
        {
            PhoneNumber = "1234555";
            Address = "ahhh";

        }
        public Contract(string phoneName)
        {
            PhoneNumber = phoneName;
        }
    }
}
