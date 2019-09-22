namespace InterfaceSegregationPrinciple.AudioBooks
{
    public interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}
