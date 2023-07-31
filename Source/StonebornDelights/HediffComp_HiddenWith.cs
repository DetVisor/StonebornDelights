using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace StonebornDelights
{
    public class HediffComp_HiddenWith : HediffComp
    {
        private HediffCompProperties_HiddenWith Props => props as HediffCompProperties_HiddenWith;

        public override bool CompDisallowVisible()
        {
            if (base.CompDisallowVisible())
            {
                return true;
            }

            for (int i = Props.hiderHediffs.Count - 1; i >= 0; i--)
            {
                if (Pawn.health.hediffSet.HasHediff(Props.hiderHediffs[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class HediffCompProperties_HiddenWith : HediffCompProperties
    {
        public List<HediffDef> hiderHediffs;

        public HediffCompProperties_HiddenWith()
        {
            compClass = typeof(HediffComp_HiddenWith);
        }
    }
}
