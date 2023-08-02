using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

[DefOf]
public class SD_DefOf
{
    static SD_DefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(SD_DefOf));
    }

    public static HediffDef SD_LightHangover;
}
