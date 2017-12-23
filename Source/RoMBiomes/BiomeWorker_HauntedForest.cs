using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using RimWorld.Planet;
using Verse;

namespace RoMBiomes
{
    public class BiomeWorker_HauntedForest : BiomeWorker_TemperateForest
    {
        public override float GetScore(Tile tile)
        {
            if (tile.WaterCovered)
            {
                return -100f;
            }
            if (tile.temperature < -10.0)
            {
                return 0f;
            }
            if (tile.rainfall < 700.0)
            {
                return 0f;
            }
            //if (Rand.Value > .008)
            //{
            //    return 0f;
            //}
            return 100000f;
            //return (float)(15.0 + (tile.temperature - 5.0) + (tile.rainfall - 600.0) / 180.0);
        }
    }
}
