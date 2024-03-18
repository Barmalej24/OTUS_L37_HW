
using System.Collections.Immutable;

namespace OTUS_L37_3_HW.Part
{
    public class Part3
    {
        private ImmutableList<string> poem = ImmutableList.Create<string>();
        public ImmutableList<string> Poem
        {
            get => poem;
        }

        public void AddPart(ImmutableList<string> args = null)
        {
            if (args != null)
            {
                poem = ImmutableList.Create(args.ToArray());
            }

            poem = poem.Add("А это веселая птица-синица,")
                       .Add("Которая часто ворует пшеницу,")
                       .Add("Которая в темном чулане хранится")
                       .Add("В доме,")
                       .Add("Который построил Джек.\n");
        }
    }
}
