﻿using System.Collections.Frozen;
using System.Numerics;

namespace eft_dma_shared.Common.Misc.Data {

    /// <summary>
    /// Contains Static Game Data.
    /// </summary>
    public static class GameData {

        /// <summary>
        /// All Map Names by their Map ID.
        /// </summary>
        public static FrozenDictionary<string, string> MapNames { get; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {
            ["default"] = "default",
            ["woods"] = "Woods",
            ["shoreline"] = "Shoreline",
            ["rezervbase"] = "Reserve",
            ["laboratory"] = "Labs",
            ["interchange"] = "Interchange",
            ["factory4_day"] = "Factory",
            ["factory4_night"] = "Factory",
            ["bigmap"] = "Customs",
            ["lighthouse"] = "Lighthouse",
            ["tarkovstreets"] = "Streets",
            ["Sandbox"] = "Ground Zero",
            ["Sandbox_high"] = "Ground Zero",
            ["Labyrinth"] = "The Labyrinth",
            ["Arena_RailwayStation"] = "Skybridge",
            ["Arena_AirPit"] = "Air pit",
            ["Arena_equator_TDM_02"] = "Equator",
            ["Arena_Bowl"] = "Bowl",
            ["Arena_saw"] = "Sawmill",
            ["Arena_Bay5"] = "Bay 5",
            ["Arena_AutoService"] = "Chop Shop",
            ["Arena_Yard"] = "Yard",
            ["Arena_Prison"] = "Fort",
            ["Arena_Iceberg"] = "Iceberg"
        }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Exfil Names.
        /// First Key: Map ID
        /// Second Key: Internal Extract Name
        /// </summary>
        public static FrozenDictionary<string, FrozenDictionary<string, string>> ExfilNames { get; } = new Dictionary<string, FrozenDictionary<string, string>>(StringComparer.OrdinalIgnoreCase)
        {
            { "woods", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                // PMC
                ["Factory Gate"] = "Factory Gate (Co-Op)",
                ["RUAF Gate"] = "RUAF Gate",
                ["ZB-016"] = "ZB-016",
                ["ZB-014"] = "ZB-014",
                ["UN Roadblock"] = "UN Roadblock",
                ["South V-Ex"] = "Bridge V-Ex",
                ["Outskirts"] = "Outskirts",
                ["un-sec"] = "Northern UN Roadblock",
                // SCAV
                ["Factory Gate (Co-Op)"] = "Factory Gate (Co-Op)",
                ["Outskirts Water"] = "Scav Bridge",
                ["Dead Man's Place"] = "Dead Man's Place",
                ["The Boat"] = "Boat",
                ["Scav House"] = "Scav House",
                ["East Gate"] = "Scav Bunker",
                ["Mountain Stash"] = "Mountain Stash",
                ["West Border"] = "Eastern Rocks",
                ["Old Station"] = "Old Railway Depot",
                ["RUAF Roadblock"] = "RUAF Roadblock",
            }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase) },
            { "shoreline", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                // PMC
                ["Shorl_V-Ex"] = "Road to North V-Ex",
                ["Road to Customs"] = "Road to Customs",
                ["Road_at_railbridge"] = "Railway Bridge",
                ["Tunnel"] = "Tunnel",
                ["Lighthouse_pass"] = "Path to Lighthouse",
                ["Smugglers_Trail_coop"] = "Smuggler's Path (Co-op)",
                ["Pier Boat"] = "Pier Boat",
                ["RedRebel_alp"] = "Climber's Trail",
                // SCAV
                ["Scav Road to Customs"] = "Road to Customs",
                ["Lighthouse"] = "Lighthouse",
                ["Wrecked Road"] = "Ruined Road",
                ["South Fence Passage"] = "Old Bunker",
                ["RWing Gym Entrance"] = "East Wing Gym Entrance",
                ["Adm Basement"] = "Admin Basement",
                ["Smuggler's Path (Co-op)"] = "Smuggler's Path (Co-op)",
            }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase) },
            { "Labyrinth", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["labir_exit"] = "The Way Up",
                ["labyrinth_secret_tagilla_key"] = " Aridane's Path",
            }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase) },
            { "rezervbase", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                // PMC
                ["EXFIL_Bunker_D2"] = "D-2",
                ["EXFIL_Bunker"] = "Bunker Hermetic Door",
                ["Alpinist"] = "Cliff Descent",
                ["EXFIL_ScavCooperation"] = "Scav Lands (Co-Op)",
                ["EXFIL_vent"] = "Sewer Manhole",
                ["EXFIL_Train"] = "Armored Train",
                // SCAV
                ["Bunker Hermetic Door"] = "Depot Hermetic Door",
                ["Scav Lands (Co-Op)"] = "Scav Lands (Co-Op)",
                ["Sewer Manhole"] = "Sewer Manhole",
                ["Exit1"] = "Hole in the Wall by the Mountains",
                ["Exit2"] = "Heating Pipe",
                ["Exit3"] = "??",
                ["Exit4"] = "Checkpoint Fence",
                ["Armored Train"] = "Armored Train",
            }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase) },
            { "laboratory", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                // PMC
                ["lab_Elevator_Cargo"] = "Cargo Elevator",
                ["lab_Elevator_Main"] = "Main Elevator",
                ["lab_Vent"] = "Ventilation Shaft",
                ["lab_Elevator_Med"] = "Medical Block Elevator",
                ["lab_Under_Storage_Collector"] = "Sewage Conduit",
                ["lab_Parking_Gate"] = "Parking Gate",
                ["lab_Hangar_Gate"] = "Hangar Gate"
                // No Scav Exfils
            }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase) },
            { "interchange", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                // PMC
                ["SE Exfil"] = "Emercom Checkpoint",
                ["NW Exfil"] = "Railway Exfil",
                ["PP Exfil"] = "Power Station V-Ex",
                ["Interchange Cooperation"] = "Scav Camp (Co-Op)",
                ["Hole Exfill"] = "Hole in the Fence",
                ["Saferoom Exfil"] = "Saferoom Exfil",
                // SCAV
                ["Emercom Checkpoint"] = "Emercom Checkpoint",
                ["Railway Exfil"] = "Railway Exfil",
                ["Scav Camp (Co-Op)"] = "Scav Camp (Co-Op)",
            }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase) },
            { "factory4_day", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                // PMC
                ["Cellars"] = "Cellars",
                ["Gate 3"] = "Gate 3",
                ["Gate 0"] = "Gate 0",
                ["Gate m"] = "Med Tent Gate",
                // SCAV
                ["Camera Bunker Door"] = "Camera Bunker Door",
                ["Office Window"] = "Office Window",
            }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase) },
            { "factory4_night", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                // PMC
                ["Cellars"] = "Cellars",
                ["Gate 3"] = "Gate 3",
                ["Gate 0"] = "Gate 0",
                ["Gate m"] = "Med Tent Gate",
                // SCAV
                ["Camera Bunker Door"] = "Camera Bunker Door",
                ["Office Window"] = "Office Window",
            }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase) },
            { "bigmap", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                // PMC
                ["EXFIL_ZB013"] = "ZB-013",
                ["Dorms V-Ex"] = "Dorms V-Ex",
                ["ZB-1011"] = "ZB-1011",
                ["Crossroads"] = "Crossroads",
                ["Old Gas Station"] = "Old Gas Station",
                ["Trailer Park"] = "Trailer Park",
                ["RUAF Roadblock"] = "RUAF Roadblock",
                ["Smuggler's Boat"] = "Smuggler's Boat",
                ["ZB-1012"] = "ZB-1012",
                // SCAV
                ["Shack"] = "Military Base CP",
                ["Beyond Fuel Tank"] = "Passage Between Rocks",
                ["Railroad To Military Base"] = "Railroad to Military Base",
                ["Old Road Gate"] = "Old Road Gate",
                ["Sniper Roadblock"] = "Sniper Roadblock",
                ["Railroad To Port"] = "Railroad To Port",
                ["Trailer Park Workers Shack"] = "Trailer Park Workers Shack",
                ["Railroad To Tarkov"] = "Railroad To Tarkov",
                ["RUAF Roadblock_scav"] = "RUAF Roadblock",
                ["Warehouse 17"] = "Warehouse 17",
                ["Factory Shacks"] = "Factory Shacks",
                ["Warehouse 4"] = "Warehouse 4",
                ["Old Azs Gate"] = "Old Gas Station",
                ["Factory Far Corner"] = "Factory Far Corner",
                ["Administration Gate"] = "Administration Gate",
                ["Military Checkpoint"] = "Scav Checkpoint",
            }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase) },
            { "lighthouse", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                // PMC
                ["V-Ex_light"] = "Road to Military Base V-Ex",
                ["tunnel_shared"] = "Side Tunnel (Co-Op)",
                ["Alpinist_light"] = "Mountain Pass",
                ["Shorl_free"] = "Path to Shoreline",
                ["Nothern_Checkpoint"] = "Northern Checkpoint",
                ["Coastal_South_Road"] = "Southern Road",
                ["EXFIL_Train"] = "Armored Train",
                // SCAV
                ["Side Tunnel (Co-Op)"] = "Side Tunnel (Co-Op)",
                ["Shorl_free_scav"] = "Path to Shoreline",
                ["Scav_Coastal_South"] = "Southern Road",
                ["Scav_Underboat_Hideout"] = "Hideout Under the Landing Stage",
                ["Scav_Hideout_at_the_grotto"] = "Scav Hideout at the Grotto",
                ["Scav_Industrial_zone"] = "Industrial Zone Gates",
                ["Armored Train"] = "Armored Train",
            }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase) },
            { "tarkovstreets", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                // PMC
                ["E8_yard"] = "Courtyard",
                ["E7_car"] = "Primorsky Ave Taxi V-Ex",
                ["E1"] = "Stylobate Building Elevator",
                ["E4"] = "Crash Site",
                ["E2"] = "Sewer River",
                ["E3"] = "Damaged House",
                ["E5"] = "Collapsed Crane",
                ["E6"] = "??",
                ["E9_sniper"] = "Klimov Street",
                ["Exit_E10_coop"] = "Pinewood Basement (Co-Op)",
                ["E7"] = "Expo Checkpoint",
                // SCAV
                ["scav_e1"] = "Basement Descent",
                ["scav_e2"] = "Entrance to Catacombs",
                ["scav_e3"] = "Ventilation Shaft",
                ["scav_e4"] = "Sewer Manhole",
                ["scav_e5"] = "Near Kamchatskaya Arch",
                ["scav_e7"] = "Cardinal Apartment Complex Parking",
                ["scav_e8"] = "Klimov Shopping Mall Exfil",
            }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase) },
            { "Sandbox", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                // PMC
                ["Sandbox_VExit"] = "Police Cordon V-Ex",
                ["Unity_free_exit"] = "Emercom Checkpoint",
                ["Scav_coop_exit"] = "Scav Checkpoint (Co-Op)",
                ["Nakatani_stairs_free_exit"] = "Nakatani Basement Stairs",
                ["Sniper_exit"] = "Mira Ave",
                // SCAV
                ["Scav Checkpoint (Co-Op)"] = "Scav Checkpoint (Co-Op)",
                ["Emercom Checkpoint"] = "Emercom Checkpoint",
                ["Nakatani Basement Stairs"] = "Nakatani Basement Stairs",
            }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase) },
            { "Sandbox_high", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                // PMC
                ["Sandbox_VExit"] = "Police Cordon V-Ex",
                ["Unity_free_exit"] = "Emercom Checkpoint",
                ["Scav_coop_exit"] = "Scav Checkpoint (Co-Op)",
                ["Nakatani_stairs_free_exit"] = "Nakatani Basement Stairs",
                ["Sniper_exit"] = "Mira Ave",
                // SCAV
                ["Scav Checkpoint (Co-Op)"] = "Scav Checkpoint (Co-Op)",
                ["Emercom Checkpoint"] = "Emercom Checkpoint",
                ["Nakatani Basement Stairs"] = "Nakatani Basement Stairs",
            }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase) },
        }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase);

        public static FrozenDictionary<string, Memory<Vector3>> Mines { get; } = new Dictionary<string, Memory<Vector3>>(StringComparer.OrdinalIgnoreCase) {
            ["shoreline"] = new Vector3[]
            {
                new Vector3(499.9635f, -39.92999f, -72.69531f),
                new Vector3(-699.439f, -29.50998f, -273.5012f),
                new Vector3(-691.5459f, -4.029968f, -375.4694f),
                new Vector3(-599.7345f, -4.029968f, -372.1453f),
                new Vector3(-744.8279f, -29.50998f, -241.6526f),
                new Vector3(105.4431f, -27.02997f, -403.9787f),
                new Vector3(-635.5005f, -4.029968f, -357.414f),
                new Vector3(498.1739f, -39.92999f, 136.2064f),
                new Vector3(-787.1689f, -24.60001f, -164.4056f),
                new Vector3(239.4597f, -27.02997f, -342.4171f),
                new Vector3(494.5426f, -39.92999f, 50.37054f),
                new Vector3(-648.1046f, -4.029968f, -373.7787f),
                new Vector3(-737.3292f, -15.22998f, -308.6106f),
                new Vector3(-554.8488f, -4.029968f, -417.788f),
                new Vector3(-765.0375f, -24.60001f, -275.8228f),
                new Vector3(-931.86f, -55.2f, 417.52f),
                new Vector3(-890.94f, -55.2f, 455.55f)
            },
            ["woods"] = new Vector3[]
            {
                new Vector3(-645.4855f, 19.97001f, -155.1335f),
                new Vector3(463.9968f, 21.35f, -422.8937f),
                new Vector3(563.6989f, -5.529996f, 31.74424f),
                new Vector3(324.341f, 21.35f, -459.362f),
                new Vector3(275.7999f, -10.45f, 421.865f),
                new Vector3(577.9504f, -10.45f, 308.2255f),
                new Vector3(452.8595f, 21.35f, -710.1129f),
                new Vector3(468.3384f, 21.35f, -574.8652f),
                new Vector3(508.127f, 13.86176f, -250.842f),
                new Vector3(330.9692f, 21.35f, -507.4193f),
                new Vector3(480.4347f, -10.45f, 411.8292f)
            },
            ["lighthouse"] = new Vector3[]
            {
                new Vector3(-227.9976f, 13.94f, -520.8323f),
                new Vector3(-5.122513f, 7.400002f, -424.614f),
                new Vector3(-500.6f, 43.8f, -515.35f),
                new Vector3(-147.3805f, 5.399998f, -482.0828f),
                new Vector3(-139.1587f, 7.400002f, -450.7613f),
                new Vector3(-242.2297f, 18.1f, -478.8835f),
                new Vector3(52.59197f, 7.400002f, -468.8979f),
                new Vector3(49.40002f, 21.505f, -1004.75f),
                new Vector3(-551.0999f, 43.8f, -393.55f),
                new Vector3(40.47018f, 7.400002f, -404.0539f),
                new Vector3(-105.1f, 21.505f, -1007.75f),
                new Vector3(75.58275f, 11.61f, -419.8874f),
                new Vector3(-331.39f, 33.6f, -523.8537f),
                new Vector3(57.73361f, 7.400002f, -522.3037f),
                new Vector3(-330.2926f, 39.67f, -490.8548f),
                new Vector3(-448.7f, 22.8f, -785.8f),
                new Vector3(30.35561f, 12.3f, -750.6716f),
                new Vector3(243.467f, 0.06f, 534.935f),
                new Vector3(218.545f, 0.296f, 510.691f),
                new Vector3(305.809f, 1.946f, 502.395f),
                new Vector3(212.385f, 0.191f, 509.581f),
                new Vector3(234.907f, 1.876f, 518.332f),
                new Vector3(245.038f, 0.106f, 532.528f),
                new Vector3(267.026f, 1.9413f, 523.865f),
                new Vector3(313.064f, 1.819f, 510.908f),
                new Vector3(-254.375f, 27.914f, -566.485f),
                new Vector3(241.506f, 0.291f, 529.897f),
                new Vector3(-261.801f, 30.935f, -564.372f),
                new Vector3(216.867f, 0.218f, 529.055f),
                new Vector3(204.669f, 0.256f, 509.298f),
                new Vector3(227.034f, 0.17f, 526.597f),
                new Vector3(213.289f, 0.283f, 513.858f),
                new Vector3(-241.043f, 20.353f, -551.301f),
                new Vector3(-304.48f, 36.018f, -590.176f),
                new Vector3(-302.0087f, 34.9046f, -601.7734f),
                new Vector3(243.095f, 0.239f, 512.974f),
                new Vector3(-226.5704f, 17.129f, -568.9507f),
                new Vector3(209.8172f, 1.8455f, 519.1801f),
                new Vector3(287.989f, 1.831f, 511.113f),
                new Vector3(240.522f, 0.261f, 529.29f),
                new Vector3(281.0385f, 1.9916f, 509.6941f),
                new Vector3(225.505f, 0.2f, 508.035f),
                new Vector3(261.784f, 1.81f, 524.219f),
                new Vector3(215.506f, 2.212f, 523.973f),
                new Vector3(314.293f, 2.02f, 512.347f),
                new Vector3(-299.326f, 36.809f, -591.756f),
                new Vector3(242.773f, 1.805f, 514.362f),
                new Vector3(204.56f, 0.196f, 513.489f),
                new Vector3(221.26f, 0.247f, 529.405f),
                new Vector3(231.71f, 1.922f, 523.019f),
                new Vector3(188.267f, 0.22f, 512.059f),
                new Vector3(208.918f, 0.199f, 511.258f),
                new Vector3(219.691f, -0.04f, 533.976f),
                new Vector3(210.84f, 1.808f, 516.62f),
                new Vector3(224.375f, 0.203f, 530.353f),
                new Vector3(282.3838f, 1.941f, 520.9704f),
                new Vector3(292.245f, 1.851f, 511.783f),
                new Vector3(313.573f, 2.1749f, 511.481f),
                new Vector3(265.621f, 1.987f, 514.836f),
                new Vector3(311.197f, 1.807f, 502.797f),
                new Vector3(235.675f, 0.251f, 513.662f),
                new Vector3(231.517f, 0.15f, 509.4561f),
                new Vector3(-294.107f, 34.157f, -584.707f),
                new Vector3(202.114f, 0.232f, 509.03f),
                new Vector3(223.196f, 0.107f, 504.332f),
                new Vector3(228.55f, 0.148f, 508.77f),
                new Vector3(307.394f, 0.001f, 496.676f),
                new Vector3(209.24f, 0.126f, 509.643f),
                new Vector3(239.483f, 1.9675f, 516.637f),
                new Vector3(233.663f, 0.161f, 509.12f),
                new Vector3(225.16f, 0.188f, 512.872f),
                new Vector3(222.9225f, 1.846f, 520.0113f),
                new Vector3(303.735f, -0.017f, 484.437f),
                new Vector3(204.284f, 0.264f, 512.533f),
                new Vector3(252.541f, 0.103f, 511.602f),
                new Vector3(251.664f, 0.147f, 530.302f),
                new Vector3(250.874f, 0.192f, 510.51f),
                new Vector3(246.099f, 0.029f, 533.724f),
                new Vector3(242.727f, 0.194f, 532.77f),
                new Vector3(241.321f, 0.26f, 511.347f),
                new Vector3(288.9668f, 0.2685f, 503.1812f),
                new Vector3(311.813f, 2.02f, 499.782f),
                new Vector3(242.398f, 0.324f, 526.56f),
                new Vector3(249.112f, 0.289f, 528.831f),
                new Vector3(210.786f, 0.078f, 531.712f),
                new Vector3(229.978f, 0.295f, 512.848f),
                new Vector3(221.231f, 0.208f, 530.59f),
                new Vector3(250.654f, 0.117f, 531.424f),
                new Vector3(310.712f, 2.5435f, 501.1422f),
                new Vector3(312.734f, 0.009f, 516.965f),
                new Vector3(305.01f, 1.8079f, 513.95f),
                new Vector3(277.671f, 1.808f, 515.202f),
                new Vector3(214.3559f, 0.1089f, 505.0143f),
                new Vector3(-306.3855f, 33.7312f, -605.2985f),
                new Vector3(250.478f, 0.214f, 529.053f),
                new Vector3(218.194f, 0.001f, 533.442f),
                new Vector3(227.412f, 2.076f, 514.884f),
                new Vector3(-213.891f, 19.136f, -572.236f),
                new Vector3(265.093f, 1.811f, 513.836f),
                new Vector3(267.79f, 1.804f, 512.263f),
                new Vector3(276.736f, 1.795f, 513.9884f),
                new Vector3(247.271f, 0.1f, 510.983f),
                new Vector3(259.936f, 1.811f, 520.864f),
                new Vector3(242.277f, 0.251f, 513.763f),
                new Vector3(-297.62f, 35.021f, -592.334f),
                new Vector3(-302.316f, 34.99f, -601.562f),
                new Vector3(280.814f, 1.87f, 514.124f),
                new Vector3(194.924f, 0.499f, 513.597f),
                new Vector3(189.914f, 0.123f, 508.848f),
                new Vector3(216.931f, 0.131f, 507.189f),
                new Vector3(-230.42f, 18.326f, -577.458f),
                new Vector3(-285.777f, 31.734f, -583.832f),
                new Vector3(243.954f, 0.223f, 529.512f),
                new Vector3(247.851f, 1.847f, 517.421f),
                new Vector3(216.0778f, 2.139f, 517.0784f),
                new Vector3(217.797f, 2.08f, 516.992f),
                new Vector3(219.4027f, 0.337f, 510.5761f),
                new Vector3(214.897f, 2.009f, 516.243f),
                new Vector3(240.0462f, 0.238f, 530.9058f),
                new Vector3(-325.07f, 32.883f, -583.522f),
                new Vector3(251.121f, 2.001f, 524.156f),
                new Vector3(217.61f, 0.1797f, 529.814f),
                new Vector3(-250.558f, 29.142f, -557.882f),
                new Vector3(242.346f, 0.209f, 510.017f)
            },
            ["tarkovstreets"] = new Vector3[]
            {
                new Vector3(92.283f, 2.9507f, 263.573f),
                new Vector3(88.697f, 3.3873f, 371.708f),
                new Vector3(83.009f, 2.8501f, 263.2695f),
                new Vector3(104.822f, 3.418f, 308.075f),
                new Vector3(105.357f, 2.977f, 352.216f),
                new Vector3(105.35f, 3.05f, 366.73f),
                new Vector3(92.775f, 3.3893f, 374.857f),
                new Vector3(98.94f, 2.916f, 262.71f),
                new Vector3(46.501f, 2.7206f, 267.643f),
                new Vector3(37.80185f, 2.722f, 269.9368f),
                new Vector3(105.1584f, 3.722f, 287.9238f),
                new Vector3(47.919f, 2.7251f, 268.033f),
                new Vector3(45.207f, 2.7263f, 272.843f),
                new Vector3(52.22114f, 2.725f, 267.9434f),
                new Vector3(36.72f, 2.828f, 261.89f),
                new Vector3(67.935f, 2.777f, 263.191f),
                new Vector3(88.78127f, 3.4018f, 373.5036f),
                new Vector3(58.8f, 2.7403f, 263.57f),
                new Vector3(102.2167f, 3.428f, 379.8588f),
                new Vector3(105.4046f, 3.2931f, 373.3855f),
                new Vector3(48.675f, 2.67f, 269.606f),
                new Vector3(106.95f, 3.733f, 301.691f),
                new Vector3(45.242f, 2.7206f, 268.472f),
                new Vector3(105.0592f, 2.9542f, 352.677f),
                new Vector3(45.867f, 2.7263f, 271.54f),
                new Vector3(40.916f, 2.7233f, 273.72f),
                new Vector3(107.006f, 3.722f, 295.373f),
                new Vector3(38.927f, 2.7252f, 269.149f),
                new Vector3(92.785f, 3.4446f, 375.69f),
                new Vector3(42.874f, 2.7241f, 276.938f),
                new Vector3(103.822f, 2.755f, 363.753f),
                new Vector3(52.78309f, 2.7246f, 329.9346f),
                new Vector3(54.088f, 2.831f, 260.994f),
                new Vector3(45.06f, 2.8152f, 262.17f),
                new Vector3(52.38234f, 2.7343f, 272.6624f),
                new Vector3(48.372f, 2.7343f, 274.492f),
                new Vector3(85.5906f, 2.9507f, 260.9251f),
                new Vector3(92.09009f, 3.4253f, 368.8048f),
                new Vector3(85.997f, 2.9507f, 260.866f),
                new Vector3(100.5803f, 3.4782f, 373.1563f),
                new Vector3(62.1f, 2.7403f, 260.86f),
                new Vector3(35.624f, 2.7189f, 269.117f),
                new Vector3(93.70396f, 3.4114f, 374.884f),
                new Vector3(38.04f, 2.6144f, 267.708f),
                new Vector3(103.822f, 2.755f, 361.009f),
                new Vector3(53.70294f, 2.726f, 326.0333f),
                new Vector3(106.322f, 3.231f, 367.113f),
                new Vector3(53.6932f, 2.7457f, 324.678f),
                new Vector3(43.0699f, 2.6349f, 275.6749f),
                new Vector3(105.0592f, 2.987f, 351.97f),
                new Vector3(48.46088f, 2.7263f, 320.8043f),
                new Vector3(44.48053f, 2.7234f, 279.8209f),
                new Vector3(49.102f, 2.67f, 268.956f),
                new Vector3(46.433f, 2.715f, 297.83f),
                new Vector3(46.85299f, 2.7884f, 291.3539f),
                new Vector3(93.62f, 2.916f, 263.76f),
                new Vector3(45.088f, 2.67f, 270.134f),
                new Vector3(105.332f, 3.0646f, 367.954f),
                new Vector3(50.462f, 2.7343f, 274.458f),
                new Vector3(99.65798f, 3.4866f, 372.6137f)
            },
            ["Sandbox"] = new Vector3[]
            {
                new Vector3(220.8055f, 15.65f, 133.9053f),
                new Vector3(222.7634f, 15.65f, 175.4689f),
                new Vector3(60.41f, 23.578f, 170.799f)
            },
            ["Sandbox_high"] = new Vector3[]
            {
                new Vector3(220.8055f, 15.65f, 133.9053f),
                new Vector3(222.7634f, 15.65f, 175.4689f),
                new Vector3(60.41f, 23.578f, 170.799f)
            }
        }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase);

        public static IReadOnlyDictionary<int, int> XPTable { get; } = new Dictionary<int, int>
        {
            {0, 1},
            {1000, 2},
            {4017, 3},
            {8432, 4},
            {14256, 5},
            {21477, 6},
            {30023, 7},
            {39936, 8},
            {51204, 9},
            {63723, 10},
            {77563, 11},
            {92713, 12},
            {111881, 13},
            {134674, 14},
            {161139, 15},
            {191417, 16},
            {225194, 17},
            {262366, 18},
            {302484, 19},
            {345751, 20},
            {391649, 21},
            {440444, 22},
            {492366, 23},
            {547896, 24},
            {609066, 25},
            {679255, 26},
            {755444, 27},
            {837672, 28},
            {925976, 29},
            {1020396, 30},
            {1120969, 31},
            {1227735, 32},
            {1344260, 33},
            {1470605, 34},
            {1606833, 35},
            {1759965, 36},
            {1923579, 37},
            {2097740, 38},
            {2282513, 39},
            {2477961, 40},
            {2684149, 41},
            {2901143, 42},
            {3132824, 43},
            {3379281, 44},
            {3640603, 45},
            {3929436, 46},
            {4233995, 47},
            {4554372, 48},
            {4890662, 49},
            {5242956, 50},
            {5611348, 51},
            {5995931, 52},
            {6402287, 53},
            {6830542, 54},
            {7280825, 55},
            {7753260, 56},
            {8247975, 57},
            {8765097, 58},
            {9304752, 59},
            {9876880, 60},
            {10512365, 61},
            {11193911, 62},
            {11929835, 63},
            {12727177, 64},
            {13615989, 65},
            {14626588, 66},
            {15864243, 67},
            {17555001, 68},
            {19926895, 69},
            {22926895, 70},
            {26526895, 71},
            {30726895, 72},
            {35526895, 73},
            {40926895, 74},
            {46926895, 75},
            {53526895, 76},
            {60726895, 77},
            {69126895, 78},
            {81126895, 79}
        };
    }
}