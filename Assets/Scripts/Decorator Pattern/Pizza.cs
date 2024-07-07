using System.Collections.Generic;

namespace GamePatterns
{
    /// <summary>
    /// This class is a concrete implementation of the base interface
    /// </summary>
    public class Pizza : IPizza
    {
        public List<string> GetIngredients()
        {
            List<string> Base = new List<string>
            {
                "Pizza Base"
            };

            return Base;
        }
    }
}
