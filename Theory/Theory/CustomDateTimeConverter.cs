using Newtonsoft.Json.Converters;

namespace Theory
{
    internal class CustomDateTimeConverter: IsoDateTimeConverter
    {
        public CustomDateTimeConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd";
        }
    }
}