namespace Team3
{
    public class Contact
    {
        public Contact()
        {

        }

        public string EmployeeName {  get; set; }
        public string EmergencyContactName {  get; set; }
        public string EmergencyContactNumber {  get; set; }
        public string Relation {  get; set; }

        //override to string
        public override string ToString()
        {
            var details = string.Format("{0} - {1} emergency contact number {2}", EmployeeName, EmergencyContactName, EmergencyContactNumber);
            return details;
        }
    }
}