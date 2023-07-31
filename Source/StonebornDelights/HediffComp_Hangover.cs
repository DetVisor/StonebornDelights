using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;

namespace StonebornDelights
{
    public class HediffComp_Hangover : HediffComp
    {
        private HediffCompProperties_Hangover Props => props as HediffCompProperties_Hangover;

        public override void CompPostTick(ref float severityAdjustment)
        {
            base.CompPostTick(ref severityAdjustment);

            if (parent.CurStageIndex < Props.minHangoverStage || !Pawn.IsHashIntervalTick(300))
            {
                return;
            }

            Hediff hediff = Pawn.health.hediffSet.GetFirstHediffOfDef(Props.hangover);

            if (hediff != null)
            {
                hediff.Severity = 1f;
                return;
            }

            hediff = HediffMaker.MakeHediff(Props.hangover, Pawn);
            hediff.Severity = 1f;
            Pawn.health.AddHediff(hediff);
        }
    }

    public class HediffCompProperties_Hangover : HediffCompProperties
    {
        public HediffDef hangover;
        public int minHangoverStage = 3;

        public HediffCompProperties_Hangover()
        {
            compClass = typeof(HediffComp_Hangover);
        }
    }
}
