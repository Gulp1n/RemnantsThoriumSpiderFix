using Terraria;
using Terraria.ModLoader;
using ThoriumMod;
using ThoriumMod.Utilities;

namespace RemnantsThoriumSpiderFix.Content;

public class BrownRecluseWall : ThoriumMod.NPCs.BrownRecluseWall
{
    public override float SpawnChance(NPCSpawnInfo spawnInfo)
    {
        return !Main.hardMode || !ThoriumWorld.downedBoreanStrider || !spawnInfo.Player.InModBiome(ModContent.GetInstance<Remnants.Content.Biomes.ForgottenTomb>())? 0.0f : 1f;
    } 
}