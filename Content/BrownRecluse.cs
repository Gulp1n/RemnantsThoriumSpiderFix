using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Chat;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.ModLoader;
using ThoriumMod;
using ThoriumMod.NPCs;

namespace RemnantsThoriumSpiderFix.Content;

public class BrownRecluse : ThoriumMod.NPCs.BrownRecluse
{
    public override float SpawnChance(NPCSpawnInfo spawnInfo)
    {
        return !Main.hardMode || !ThoriumWorld.downedBoreanStrider || !spawnInfo.Player.InModBiome(ModContent.GetInstance<Remnants.Content.Biomes.ForgottenTomb>())? 0.0f : 1f;
    }
}