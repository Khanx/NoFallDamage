namespace NoFallDamage
{
    [ModLoader.ModManager]
    public static class NoFallDamage
    {
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerHit, "Khanx.NoFallDamage.OnPlayerHit")]
        public static void OnPlayerHit(Players.Player player, ModLoader.OnHitData d)
        {
            if (null == player || null == d || d.HitSourceType != ModLoader.OnHitData.EHitSourceType.FallDamage)
                return;

             if (d.ResultDamage < 0) return;
                d.ResultDamage = 0;
        }

    }
}
