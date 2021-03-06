﻿using AmeisenBotX.Core.Data.Enums;
using AmeisenBotX.Core.Dungeon.Enums;
using AmeisenBotX.Core.Dungeon.Objects;
using AmeisenBotX.Core.Jobs.Profiles;
using AmeisenBotX.Core.Movement.Pathfinding.Objects;
using System.Collections.Generic;

namespace AmeisenBotX.Core.Dungeon.Profiles.Classic
{
    public class ShadowfangKeepProfile : IDungeonProfile
    {
        public string Author { get; } = "Jannis";

        public string Description { get; } = "Profile for the Dungeon in The Silverpine Forest, made for Level 22 to 30.";

        public DungeonFactionType FactionType { get; } = DungeonFactionType.Neutral;

        public int GroupSize { get; } = 5;

        public MapId MapId { get; } = MapId.ShadowfangKeep;

        public int MaxLevel { get; } = 30;

        public string Name { get; } = "[22-30] Shadowfang Keep";

        public List<DungeonNode> Nodes { get; } = new List<DungeonNode>()
        {
            new DungeonNode(new Vector3(-229, 2109, 77)),
            new DungeonNode(new Vector3(-221, 2110, 77)),
            new DungeonNode(new Vector3(-214, 2107, 77)),
            new DungeonNode(new Vector3(-209, 2101, 77)),
            new DungeonNode(new Vector3(-201, 2099, 77)),
            new DungeonNode(new Vector3(-200, 2107, 79)),
            new DungeonNode(new Vector3(-207, 2110, 81)),
            new DungeonNode(new Vector3(-204, 2117, 81)),
            new DungeonNode(new Vector3(-198, 2122, 82)),
            new DungeonNode(new Vector3(-193, 2129, 82)),
            new DungeonNode(new Vector3(-188, 2136, 82)),
            new DungeonNode(new Vector3(-191, 2143, 84)),
            new DungeonNode(new Vector3(-198, 2146, 86)),
            new DungeonNode(new Vector3(-205, 2147, 89)),
            new DungeonNode(new Vector3(-211, 2141, 91)),
            new DungeonNode(new Vector3(-219, 2144, 91)),
            new DungeonNode(new Vector3(-227, 2147, 91)),
            new DungeonNode(new Vector3(-235, 2148, 90)),
            new DungeonNode(new Vector3(-239, 2141, 87)),
            new DungeonNode(new Vector3(-247, 2144, 87)),
            new DungeonNode(new Vector3(-252, 2138, 84)),
            new DungeonNode(new Vector3(-254, 2131, 81)),
            new DungeonNode(new Vector3(-257, 2123, 81)),
            new DungeonNode(new Vector3(-254, 2130, 81)),
            new DungeonNode(new Vector3(-252, 2137, 84)),
            new DungeonNode(new Vector3(-250, 2144, 87)),
            new DungeonNode(new Vector3(-243, 2141, 87)),
            new DungeonNode(new Vector3(-236, 2144, 88)),
            new DungeonNode(new Vector3(-237, 2151, 91)),
            new DungeonNode(new Vector3(-241, 2158, 91)),
            new DungeonNode(new Vector3(-238, 2166, 89)),
            new DungeonNode(new Vector3(-235, 2173, 85)),
            new DungeonNode(new Vector3(-232, 2180, 81)),
            new DungeonNode(new Vector3(-229, 2187, 80)),
            new DungeonNode(new Vector3(-226, 2194, 80)),
            new DungeonNode(new Vector3(-223, 2201, 80)),
            new DungeonNode(new Vector3(-220, 2208, 80)),
            new DungeonNode(new Vector3(-216, 2215, 80)),
            new DungeonNode(new Vector3(-208, 2217, 80)),
            new DungeonNode(new Vector3(-200, 2217, 80)),
            new DungeonNode(new Vector3(-192, 2217, 80)),
            new DungeonNode(new Vector3(-184, 2217, 80)),
            new DungeonNode(new Vector3(-176, 2217, 80)),
            new DungeonNode(new Vector3(-177, 2225, 79)),
            new DungeonNode(new Vector3(-179, 2232, 76)),
            new DungeonNode(new Vector3(-180, 2240, 76)),
            new DungeonNode(new Vector3(-183, 2247, 76)),
            new DungeonNode(new Vector3(-189, 2252, 76)),
            new DungeonNode(new Vector3(-196, 2256, 76)),
            new DungeonNode(new Vector3(-203, 2260, 76)),
            new DungeonNode(new Vector3(-210, 2263, 76)),
            new DungeonNode(new Vector3(-218, 2266, 75)),
            new DungeonNode(new Vector3(-225, 2270, 75)),
            new DungeonNode(new Vector3(-232, 2274, 75)),
            new DungeonNode(new Vector3(-239, 2277, 75)),
            new DungeonNode(new Vector3(-246, 2280, 75)),
            new DungeonNode(new Vector3(-253, 2283, 75)),
            new DungeonNode(new Vector3(-260, 2287, 75)),
            new DungeonNode(new Vector3(-262, 2295, 75)),
            new DungeonNode(new Vector3(-268, 2300, 76)),
            new DungeonNode(new Vector3(-275, 2297, 76)),
            new DungeonNode(new Vector3(-270, 2291, 76)),
            new DungeonNode(new Vector3(-262, 2289, 75)),
            new DungeonNode(new Vector3(-269, 2286, 77)),
            new DungeonNode(new Vector3(-276, 2289, 81)),
            new DungeonNode(new Vector3(-283, 2292, 83)),
            new DungeonNode(new Vector3(-288, 2296, 88)),
            new DungeonNode(new Vector3(-290, 2303, 91)),
            new DungeonNode(new Vector3(-297, 2299, 91)),
            new DungeonNode(new Vector3(-301, 2293, 95)),
            new DungeonNode(new Vector3(-303, 2285, 96)),
            new DungeonNode(new Vector3(-298, 2279, 96)),
            new DungeonNode(new Vector3(-290, 2277, 96)),
            new DungeonNode(new Vector3(-282, 2275, 96)),
            new DungeonNode(new Vector3(-274, 2272, 96)),
            new DungeonNode(new Vector3(-266, 2270, 96)),
            new DungeonNode(new Vector3(-259, 2268, 100)),
            new DungeonNode(new Vector3(-252, 2264, 101)),
            new DungeonNode(new Vector3(-247, 2258, 101)),
            new DungeonNode(new Vector3(-239, 2258, 101)),
            new DungeonNode(new Vector3(-232, 2261, 102)),
            new DungeonNode(new Vector3(-224, 2263, 103)),
            new DungeonNode(new Vector3(-221, 2256, 103)),
            new DungeonNode(new Vector3(-228, 2252, 103)),
            new DungeonNode(new Vector3(-236, 2253, 101)),
            new DungeonNode(new Vector3(-244, 2254, 101)),
            new DungeonNode(new Vector3(-249, 2248, 101)),
            new DungeonNode(new Vector3(-252, 2241, 101)),
            new DungeonNode(new Vector3(-249, 2233, 100)),
            new DungeonNode(new Vector3(-243, 2230, 96)),
            new DungeonNode(new Vector3(-236, 2232, 94)),
            new DungeonNode(new Vector3(-232, 2225, 94)),
            new DungeonNode(new Vector3(-232, 2218, 97)),
            new DungeonNode(new Vector3(-235, 2211, 97)),
            new DungeonNode(new Vector3(-236, 2203, 97)),
            new DungeonNode(new Vector3(-238, 2195, 97)),
            new DungeonNode(new Vector3(-241, 2188, 97)),
            new DungeonNode(new Vector3(-244, 2181, 94)),
            new DungeonNode(new Vector3(-249, 2174, 94)),
            new DungeonNode(new Vector3(-252, 2167, 94)),
            new DungeonNode(new Vector3(-252, 2159, 94)),
            new DungeonNode(new Vector3(-256, 2153, 91)),
            new DungeonNode(new Vector3(-261, 2148, 94)),
            new DungeonNode(new Vector3(-268, 2150, 96)),
            new DungeonNode(new Vector3(-271, 2143, 96)),
            new DungeonNode(new Vector3(-264, 2140, 98)),
            new DungeonNode(new Vector3(-257, 2138, 100)),
            new DungeonNode(new Vector3(-249, 2140, 100)),
            new DungeonNode(new Vector3(-242, 2144, 100)),
            new DungeonNode(new Vector3(-242, 2136, 100)),
            new DungeonNode(new Vector3(-245, 2129, 100)),
            new DungeonNode(new Vector3(-253, 2128, 100)),
            new DungeonNode(new Vector3(-258, 2122, 100)),
            new DungeonNode(new Vector3(-258, 2114, 100)),
            new DungeonNode(new Vector3(-250, 2112, 100)),
            new DungeonNode(new Vector3(-243, 2109, 99)),
            new DungeonNode(new Vector3(-236, 2107, 97)),
            new DungeonNode(new Vector3(-229, 2104, 97)),
            new DungeonNode(new Vector3(-222, 2101, 97)),
            new DungeonNode(new Vector3(-215, 2098, 97)),
            new DungeonNode(new Vector3(-207, 2099, 97)),
            new DungeonNode(new Vector3(-204, 2106, 97)),
            new DungeonNode(new Vector3(-201, 2113, 97)),
            new DungeonNode(new Vector3(-199, 2121, 97)),
            new DungeonNode(new Vector3(-196, 2128, 97)),
            new DungeonNode(new Vector3(-193, 2135, 97)),
            new DungeonNode(new Vector3(-191, 2143, 97)),
            new DungeonNode(new Vector3(-188, 2150, 97)),
            new DungeonNode(new Vector3(-185, 2157, 97)),
            new DungeonNode(new Vector3(-183, 2165, 97)),
            new DungeonNode(new Vector3(-181, 2173, 97)),
            new DungeonNode(new Vector3(-182, 2181, 98)),
            new DungeonNode(new Vector3(-175, 2185, 97)),
            new DungeonNode(new Vector3(-170, 2179, 95)),
            new DungeonNode(new Vector3(-169, 2171, 94)),
            new DungeonNode(new Vector3(-162, 2168, 94)),
            new DungeonNode(new Vector3(-154, 2166, 94)),
            new DungeonNode(new Vector3(-147, 2163, 94)),
            new DungeonNode(new Vector3(-139, 2160, 94)),
            new DungeonNode(new Vector3(-131, 2162, 94)),
            new DungeonNode(new Vector3(-134, 2169, 94)),
            new DungeonNode(new Vector3(-140, 2173, 97)),
            new DungeonNode(new Vector3(-147, 2174, 100)),
            new DungeonNode(new Vector3(-155, 2175, 101)),
            new DungeonNode(new Vector3(-156, 2183, 104)),
            new DungeonNode(new Vector3(-150, 2188, 106)),
            new DungeonNode(new Vector3(-143, 2184, 109)),
            new DungeonNode(new Vector3(-136, 2182, 113)),
            new DungeonNode(new Vector3(-129, 2179, 113)),
            new DungeonNode(new Vector3(-122, 2176, 113)),
            new DungeonNode(new Vector3(-115, 2173, 109)),
            new DungeonNode(new Vector3(-108, 2170, 107)),
            new DungeonNode(new Vector3(-104, 2164, 104)),
            new DungeonNode(new Vector3(-106, 2157, 102)),
            new DungeonNode(new Vector3(-114, 2155, 102)),
            new DungeonNode(new Vector3(-122, 2155, 102)),
            new DungeonNode(new Vector3(-130, 2157, 102)),
            new DungeonNode(new Vector3(-137, 2161, 105)),
            new DungeonNode(new Vector3(-144, 2163, 107)),
            new DungeonNode(new Vector3(-151, 2166, 109)),
            new DungeonNode(new Vector3(-159, 2169, 109)),
            new DungeonNode(new Vector3(-166, 2172, 109)),
            new DungeonNode(new Vector3(-174, 2175, 109)),
            new DungeonNode(new Vector3(-172, 2183, 110)),
            new DungeonNode(new Vector3(-175, 2190, 112)),
            new DungeonNode(new Vector3(-183, 2190, 114)),
            new DungeonNode(new Vector3(-187, 2183, 115)),
            new DungeonNode(new Vector3(-183, 2176, 117)),
            new DungeonNode(new Vector3(-175, 2174, 119)),
            new DungeonNode(new Vector3(-172, 2181, 120)),
            new DungeonNode(new Vector3(-176, 2188, 122)),
            new DungeonNode(new Vector3(-184, 2188, 124)),
            new DungeonNode(new Vector3(-184, 2180, 126)),
            new DungeonNode(new Vector3(-177, 2176, 128)),
            new DungeonNode(new Vector3(-171, 2181, 129)),
            new DungeonNode(new Vector3(-163, 2180, 129)),
            new DungeonNode(new Vector3(-156, 2177, 129)),
            new DungeonNode(new Vector3(-149, 2174, 128)),
            new DungeonNode(new Vector3(-142, 2171, 128)),
            new DungeonNode(new Vector3(-135, 2168, 129)),
            new DungeonNode(new Vector3(-128, 2165, 129)),
            new DungeonNode(new Vector3(-120, 2163, 129)),
            new DungeonNode(new Vector3(-119, 2171, 130)),
            new DungeonNode(new Vector3(-118, 2179, 131)),
            new DungeonNode(new Vector3(-119, 2187, 132)),
            new DungeonNode(new Vector3(-124, 2194, 133)),
            new DungeonNode(new Vector3(-130, 2199, 134)),
            new DungeonNode(new Vector3(-137, 2202, 135)),
            new DungeonNode(new Vector3(-145, 2204, 135)),
            new DungeonNode(new Vector3(-153, 2203, 136)),
            new DungeonNode(new Vector3(-160, 2200, 137)),
            new DungeonNode(new Vector3(-166, 2194, 138)),
            new DungeonNode(new Vector3(-171, 2187, 139)),
            new DungeonNode(new Vector3(-166, 2181, 139)),
            new DungeonNode(new Vector3(-162, 2174, 139)),
            new DungeonNode(new Vector3(-161, 2166, 139)),
            new DungeonNode(new Vector3(-156, 2160, 139)),
            new DungeonNode(new Vector3(-149, 2157, 139)),
            new DungeonNode(new Vector3(-141, 2158, 139)),
            new DungeonNode(new Vector3(-134, 2161, 139)),
            new DungeonNode(new Vector3(-129, 2167, 139)),
            new DungeonNode(new Vector3(-121, 2165, 139)),
            new DungeonNode(new Vector3(-118, 2172, 140)),
            new DungeonNode(new Vector3(-118, 2180, 141)),
            new DungeonNode(new Vector3(-120, 2188, 143)),
            new DungeonNode(new Vector3(-125, 2194, 144)),
            new DungeonNode(new Vector3(-131, 2200, 145)),
            new DungeonNode(new Vector3(-138, 2203, 147)),
            new DungeonNode(new Vector3(-146, 2204, 148)),
            new DungeonNode(new Vector3(-154, 2202, 149)),
            new DungeonNode(new Vector3(-161, 2198, 151)),
            new DungeonNode(new Vector3(-167, 2192, 152)),
            new DungeonNode(new Vector3(-171, 2185, 152)),
            new DungeonNode(new Vector3(-165, 2180, 152)),
            new DungeonNode(new Vector3(-157, 2177, 153)),
            new DungeonNode(new Vector3(-150, 2175, 156)),
            new DungeonNode(new Vector3(-143, 2172, 156)),
            new DungeonNode(new Vector3(-136, 2169, 156)),
            new DungeonNode(new Vector3(-129, 2166, 156)),
            new DungeonNode(new Vector3(-122, 2163, 156)),
            new DungeonNode(new Vector3(-115, 2160, 156)),
            new DungeonNode(new Vector3(-110, 2154, 156)),
            new DungeonNode(new Vector3(-113, 2148, 151)),
            new DungeonNode(new Vector3(-116, 2142, 147)),
            new DungeonNode(new Vector3(-117, 2134, 145)),
            new DungeonNode(new Vector3(-109, 2133, 145)),
            new DungeonNode(new Vector3(-103, 2138, 145)),
            new DungeonNode(new Vector3(-99, 2145, 145)),
            new DungeonNode(new Vector3(-91, 2145, 145)),
            new DungeonNode(new Vector3(-84, 2141, 147)),
            new DungeonNode(new Vector3(-78, 2145, 152)),
            new DungeonNode(new Vector3(-77, 2152, 156)),
            new DungeonNode(new Vector3(-82, 2158, 156)),
        };

        public List<int> PriorityUnits { get; } = new List<int>();

        public int RequiredItemLevel { get; } = 10;

        public int RequiredLevel { get; } = 22;

        public Vector3 WorldEntry { get; } = new Vector3(-232, -1569, 77);

        public MapId WorldEntryMapId { get; } = MapId.EasternKingdoms;
    }
}