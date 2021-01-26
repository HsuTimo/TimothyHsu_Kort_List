namespace TimothyHsu_Kort_List.Interfaces
{
    public interface IProduct
    {
        string Merk { get; set; }
        string Naam { get; set; }
        string Volume { get; set; }
        string GetCode();
    }
}
