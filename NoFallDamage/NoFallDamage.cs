using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoFallDamage
{
    [ModLoader.ModManager]
    public static class NoFallDamage
    {
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerHit, "Khanx.SimpleFluids.NotKillPlayerOnHitWater")]
        public static void NoDamage(Players.Player player, ModLoader.OnHitData d)
        {
            if (null == player || null == d || d.HitSourceType != ModLoader.OnHitData.EHitSourceType.FallDamage)
                return;

            d.ResultDamage = 0;
        }

    }
}
