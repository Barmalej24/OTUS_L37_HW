﻿
using System.Collections.Immutable;

namespace OTUS_L37_3_HW.Part
{
    public class Part5
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

            poem = poem.Add("Вот пес без хвоста,")
                       .Add("Который за шиворот треплет кота,")
                       .Add("Который пугает и ловит синицу,")
                       .Add("Которая часто ворует пшеницу,")
                       .Add("Которая в темном чулане хранится")
                       .Add("В доме,")
                       .Add("Который построил Джек.\n");
        }
    }
}
