namespace WongaApplication.Domain.Options
{
    public class ConnectioStringOptions
    {
        public const string SectionName = "ConnectionStrings";
        public string PostgressConnectionString { get; set; } = null!;
    }
}
