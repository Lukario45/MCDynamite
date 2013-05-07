﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDynamite.Blocks
{
    public class BlockData
    {
        public static byte Air = (byte) 0;
	    public static byte Stone = (byte) 1;
	    public static byte Grass = (byte) 2;
	    public static byte Dirt = (byte) 3;
	    public static byte Cobblestone = (byte) 4;
	    public static byte Planks = (byte) 5;
	    public static byte Saplings = (byte) 6;
	    public static byte Bedrock = (byte) 7;
	    public static byte FlowingWater = (byte) 8;
	    public static byte Water = (byte) 9;
	    public static byte FlowingLava = (byte) 10;
	    public static byte Lava = (byte) 11;
	    public static byte Sand = (byte) 12;
	    public static byte Gravel = (byte) 13;
	    public static byte GoldOre = (byte) 14;
	    public static byte IronOre = (byte) 15;
	    public static byte CoalOre = (byte) 16;
	    public static byte Wood = (byte) 17;
	    public static byte Log = (byte) 17;
	    public static byte Leaves = (byte) 18;
	    public static byte Sponge = (byte) 19;
	    public static byte Glass = (byte) 20;
	    public static byte LapisOre = (byte) 21;
	    public static byte LapisBlock = (byte) 22;
	    public static byte Dispenser = (byte) 23;
	    public static byte Sandstone = (byte) 24;
	    public static byte NoteBlock = (byte) 25;
	    public static byte Bed = (byte) 26;
	    public static byte PoweredRail = (byte) 27;
	    public static byte DetectorRail = (byte) 28;
	    public static byte StickyPiston = (byte) 29;
	    public static byte Cobweb = (byte) 30;
	    public static byte TallGrass = (byte) 31;
	    public static byte DeadBush = (byte) 32;
	    public static byte Piston = (byte) 33;
	    public static byte PistonExtension = (byte) 34;
	    public static byte Wool = (byte) 35;
	    public static byte PistonTechBlock = (byte) 36;
	    public static byte Transparent = (byte) 36;
	    public static byte Dandelion = (byte) 37;
	    public static byte Rose = (byte) 38;
	    public static byte BrownMushroom = (byte) 39;
	    public static byte RedMushroom = (byte) 40;
	    public static byte GoldBlock = (byte) 41;
	    public static byte IronBlock = (byte) 42;
	    public static byte DoubleSlabs = (byte) 43;
	    public static byte Slab = (byte) 44;
	    public static byte Bricks = (byte) 45;
	    public static byte TNT = (byte) 46;
	    public static byte Bookshelf = (byte) 47;
	    public static byte MossyCobblestone = (byte) 48;
	    public static byte Obsidian = (byte) 49;
	    public static byte Torch = (byte) 50;
	    public static byte Fire = (byte) 51;
	    public static byte MobSpawner = (byte) 52;
	    public static byte OakWoodStairs = (byte) 53;
	    public static byte Chest = (byte) 54;
	    public static byte RedstoneWire = (byte) 55;
	    public static byte DiamondOre = (byte) 56;
	    public static byte DiamondBlock = (byte) 57;
	    public static byte CraftingTable = (byte) 58;
	    public static byte Wheat = (byte) 59;
	    public static byte Farmland = (byte) 60;
	    public static byte Furnace = (byte) 61;
	    public static byte BurningFurnace = (byte) 62;
	    public static byte Sign = (byte) 63;
	    public static byte WoodenDoor = (byte) 64;
	    public static byte Ladder = (byte) 65;
	    public static byte Rails = (byte) 66;
	    public static byte CobblestoneStairs = (byte) 67;
	    public static byte WallSign = (byte) 68;
	    public static byte Level = (byte) 69;
	    public static byte StonePressurePlate = (byte) 70;
	    public static byte IronDoor = (byte) 71;
	    public static byte WoodenPressurePlate = (byte) 72;
	    public static byte RedstoneOre = (byte) 73;
	    public static byte GlowingRedstoneOre = (byte) 74;
	    public static byte RedstoneTorchOff = (byte) 75;
	    public static byte RestoneTorch = (byte) 76;
	    public static byte Button = (byte) 77;
	    public static byte Snow = (byte) 78;
	    public static byte Ice = (byte) 79;
	    public static byte Cactus = (byte) 80;
	    public static byte ClayBlock = (byte) 82;
	    public static byte SugarCane = (byte) 83;
	    public static byte Jukebox = (byte) 84;
	    public static byte Fence = (byte) 85;
	    public static byte Pumpkin = (byte) 86;
	    public static byte Netherrack = (byte) 97;
	    public static byte SoulSand = (byte) 88;
	    public static byte GlowstoneBlock = (byte) 89;
	    public static byte NetherPortal = (byte) 90;
	    public static byte JackOLantern = (byte) 91;
	    public static byte CakeBlock = (byte) 92;
	    public static byte RedstoneRepeaterOff = (byte) 93;
	    public static byte RedstoneRepeater = (byte) 94;
	    public static byte LockedChest = (byte) 95;
	    public static byte Trapdoor = (byte) 96;
	    public static byte MonsterEgg = (byte) 97;
	    public static byte StoneBricks = (byte) 98;
	    public static byte HugeBrownMushroom = (byte) 99;
	    public static byte HugeRedMushroom = (byte) 100;
	    public static byte IronBars = (byte) 101;
	    public static byte GlassPane = (byte) 102;
	    public static byte Melon = (byte) 103;
	    public static byte PumpkinStem = (byte) 104;
	    public static byte MelonStem = (byte) 105;
	    public static byte Vines = (byte) 106;
	    public static byte FenceGate = (byte) 107;
	    public static byte BrickStairs = (byte) 108;
	    public static byte StoneBrickStairs = (byte) 109;
	    public static byte Mycelium = (byte) 110;
	    public static byte LilyPad = (byte) 111;
	    public static byte NetherBrick = (byte) 112;
	    public static byte NetherBrickFence = (byte) 113;
	    public static byte NetherBrickStairs = (byte) 114;
	    public static byte NetherWart = (byte) 115;
	    public static byte EnchantmentTable = (byte) 116;
	    public static byte BrewingStand = (byte) 117;
	    public static byte Cauldron = (byte) 118;
	    public static byte EndPortal = (byte) 119;
	    public static byte EndPortalFrame = (byte) 120;
	    public static byte EndStone = (byte) 121;
	    public static byte DragonEgg = (byte) 122;
	    public static byte RedstoneLampOff = (byte) 123;
	    public static byte RedstoneLamp = (byte) 124;
	    public static byte WoodenDoubleSlab = (byte) 125;
	    public static byte WoodenSlab = (byte) 126;
	    public static byte CocoaPlant = (byte) 127;
	    public static byte SandstoneStairs = (byte) 128;
	    public static byte EmeraldOre = (byte) 129;
	    public static byte EnderChest = (byte) 130;
	    public static byte TripwireHook = (byte) 131;
	    public static byte Tripwire = (byte) 132;
	    public static byte EmeraldBlock = (byte) 133;
	    public static byte SpruceWoodStairs = (byte) 134;
	    public static byte BirchWoodStairs = (byte) 135;
	    public static byte JungleWoodStairs = (byte) 136;
	    public static byte CommandBlock = (byte) 137;
	    public static byte BeaconBlock = (byte) 138;
	    public static byte CobblestoneWall = (byte) 139;
	    public static byte FlowerPot = (byte) 140;
	    public static byte Carrot = (byte) 141;
	    public static byte Potato = (byte) 142;
	    public static byte WoodenButton = (byte) 143;
	    public static byte Head = (byte) 144;
	    public static byte Anvil = (byte) 145;
	    public static byte TrappedChest = (byte) 146;
	    public static byte LWeightedPressurePlate = (byte) 147;
	    public static byte HWeightedPressurePlaye = (byte) 148;
	    public static byte IARedstoneComparator = (byte) 149;
	    public static byte ARedstoneComparator = (byte) 150;
	    public static byte DaylightSensor = (byte) 151;
	    public static byte RedstoneBlock = (byte) 152;
	    public static byte NetherQuartzOre = (byte) 153;
	    public static byte Hopper = (byte) 154;
	    public static byte QuartzBlock = (byte) 155;
	    public static byte QuartzStairs = (byte) 156;
	    public static byte ActivatorRail = (byte) 157;
	    public static byte Dropper = (byte) 158;
    }
}
