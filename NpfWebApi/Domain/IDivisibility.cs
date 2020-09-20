using System.Collections.Generic;

namespace Domain
{
    public interface IDivisibility
    {
        IEnumerable<NumberDetail> Get(IEnumerable<string> numbers);
    }
}
