using System.Collections.Generic;
using Remnants.Content.Walls;
using Remnants.Content.Walls.Parallax;
using Terraria;
using Terraria.ModLoader;
using ThoriumMod;

namespace RemnantsThoriumSpiderFix.Content;

public class Override : GlobalNPC
{
    public override void EditSpawnPool(IDictionary<int, float> pool, NPCSpawnInfo spawnInfo)
    {
        Tile tile = Main.tile[spawnInfo.SpawnTileX, spawnInfo.SpawnTileY];
        if ((int) tile.WallType == ModContent.WallType<forgottentomb>() || (int) tile.WallType == ModContent.WallType<TombBrickWallUnsafe>())
        {
            pool.Clear();
            pool[Main.hardMode ? 82 : 316] = 1f;
            pool[Main.hardMode ? 238 : 165] = 3f;
            if (Main.hardMode && ThoriumWorld.downedBoreanStrider)
            {
                pool[ModContent.NPCType<ThoriumMod.NPCs.BrownRecluse>()] = 0.05f;
                pool[ModContent.NPCType<ThoriumMod.NPCs.BlackWidow>()] = 0.4f;
                pool[ModContent.NPCType<ThoriumMod.NPCs.Tarantula>()] = 0.55f;
            }
            if (!NPC.savedStylist && !NPC.AnyNPCs(354))
                pool[354] = 1f;
        }
    }
}