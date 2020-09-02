using System.Collections.Generic;
/// <summary>
/// Här ska vi tillreda en läcker måltid
/// </summary>
namespace Test.GitHub
{
    public class Tacos
    {
        public List<IGoodForTacos> Ingrediens { get; set; } = new List<IGoodForTacos>();    // men ni måste kunna delas i mindre bitar
    }

    public class Cheese : IGoodForTacos
    {
        public bool IsEdibleRaw { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        // skiva



        // smälta
        public void Chop()
        {
            /// riva
        }
    }
    public abstract class Vegetable : IGoodForTacos
    {
        public bool IsEdibleRaw { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Chop()
        {
            // metoden
        }
    }

    public class Tomato : Vegetable
    {

    }

    public class Meat : IGoodForTacos
    {
        public bool IsEdibleRaw .NotImplementedException(); }

        public void Chop()
        {
            throw new System.NotImplementedException();
        }
    }
}
