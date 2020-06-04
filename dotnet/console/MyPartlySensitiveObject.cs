namespace console
{
    public class MyPartlySensitiveObject
    {
        public MyPartlySensitiveObject()
        {
        }

        public SensitiveString CPRNumber { get; set; }
        public string Gender { get; set; }
        public string FullName { get; set; }
        public SensitiveString Income { get; set; }
    }
}