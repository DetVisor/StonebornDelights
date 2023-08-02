using RimWorld;
using Verse;

namespace StonebornDelights
{
	public class IngestionOutcomeDoer_RemoveHangover : IngestionOutcomeDoer
	{
		public override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested)
		{
			Hediff firstHediffOfDef = pawn.health.hediffSet.GetFirstHediffOfDef(SD_DefOf.SD_LightHangover);
			if (firstHediffOfDef != null)
			{
				pawn.health.RemoveHediff(firstHediffOfDef);
			}
		}
	}
}