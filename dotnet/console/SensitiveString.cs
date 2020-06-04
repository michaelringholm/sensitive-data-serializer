namespace console
{
    public class SensitiveString {
        public string StringValue { get; set; }
        public SensitiveString(string val) {
            StringValue = val;
        }

        public string ToSecureString() {
            return "*******";
        }
    }
}