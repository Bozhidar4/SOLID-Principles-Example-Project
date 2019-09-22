using System.Collections.Generic;

namespace InterfaceSegregationPrinciple.DVDs
{
    public interface IDVD : ILibraryItem
    {
        List<string> Actors { get; set; }
        int RuntimeInMinutes { get; set; }
    }
}
