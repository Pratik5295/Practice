
using System.Collections.Generic;

namespace GamePatterns
{
    /// <summary>
    /// This interface will serve as the base interface
    /// for the decorator pattern
    /// We will dynamically add more ingredients to the pizza
    /// and list them out
    /// </summary>
    public interface IPizza
    {
        //{ return string.Empty; }
        List<string> GetIngredients();
    }
}
