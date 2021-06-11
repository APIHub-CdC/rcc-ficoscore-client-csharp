using Newtonsoft.Json.Converters;

namespace IO.RccFicoscore.Client
{
    public class ApihubDateConverter : IsoDateTimeConverter
    {
        public ApihubDateConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
