using Orc.Library.Dictionaries;



namespace Orc.Library.Messages.Server
{
    public class DividendCollection : OrcMessage
    {
        public InstrumentId instrument_id { get; set; }

        public Dividends Dividends { get; set; }
    }
}
