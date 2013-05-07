using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Substrate;
using System.IO;
using Substrate.Core;

namespace MCDynamite
{
    public class World
    {
        public static NbtWorld world;

        public static void GenerateFlat(string path, string name)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            world = AnvilWorld.Create(path);

            IChunkManager cm = world.GetChunkManager();

            world.Level.LevelName = name;
            world.Level.Spawn = new SpawnPoint(20, 70, 20);

            int xmin = -20;
            int xmax = 20;
            int zmin = -20;
            int zmaz = 20;

            for (int xi = xmin; xi < xmax; xi++)
            {
                for (int zi = zmin; zi < zmaz; zi++)
                {
                    ChunkRef chunk = cm.CreateChunk(xi, zi);

                    chunk.IsTerrainPopulated = true;

                    chunk.Blocks.AutoLight = false;

                    FlatChunk(chunk, 64);

                    chunk.Blocks.RebuildHeightMap();
                    chunk.Blocks.RebuildBlockLight();
                    chunk.Blocks.RebuildSkyLight();

                    cm.Save();
                }
            }

            world.Save();
        }

        public static void Load(string path)
        {
            NbtWorld srcWorld = NbtWorld.Open(path);
        }

        static void FlatChunk(ChunkRef chunk, int height)
        {
            // Create bedrock
            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x < 16; x++)
                {
                    for (int z = 0; z < 16; z++)
                    {
                        chunk.Blocks.SetID(x, y, z, (int)BlockType.BEDROCK);
                    }
                }
            }

            // Create stone
            for (int y = 2; y < height - 5; y++)
            {
                for (int x = 0; x < 16; x++)
                {
                    for (int z = 0; z < 16; z++)
                    {
                        chunk.Blocks.SetID(x, y, z, (int)BlockType.STONE);
                    }
                }
            }

            // Create dirt
            for (int y = height - 5; y < height - 1; y++)
            {
                for (int x = 0; x < 16; x++)
                {
                    for (int z = 0; z < 16; z++)
                    {
                        chunk.Blocks.SetID(x, y, z, (int)BlockType.DIRT);
                    }
                }
            }

            // Create grass
            for (int y = height - 1; y < height; y++)
            {
                for (int x = 0; x < 16; x++)
                {
                    for (int z = 0; z < 16; z++)
                    {
                        chunk.Blocks.SetID(x, y, z, (int)BlockType.GRASS);
                    }
                }
            }
        }
    }
}
