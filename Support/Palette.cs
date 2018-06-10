using System.Collections.Generic;
using RLNET;

namespace RLEngine.Support.Palette
{
	public static class Palette
	{
		// Colour list taken from http://cloford.com/resources/colours/500col.htm
		public static Dictionary<string, RLColor> colors = new Dictionary<string, RLColor>
		{
			{"IndianRed",                   new RLColor(176,  23,  31)},
			{"Crimson",                     new RLColor(220,  20,  60)},
			{"LightPink",                   new RLColor(255, 182, 193)},
			{"LightPinkOne",                new RLColor(255, 174, 185)},
			{"LightPinkTwo",                new RLColor(238, 162, 173)},
			{"LightPinkThree",              new RLColor(205, 140, 149)},
			{"LightPinkFour",               new RLColor(139,  95, 101)},
			{"Pink",                        new RLColor(255, 192, 203)},
			{"PinkOne",                     new RLColor(255, 181, 197)},
			{"PinkTwo",                     new RLColor(238, 169, 184)},
			{"PinkThree",                   new RLColor(205, 145, 158)},
			{"PinkFour",                    new RLColor(139,  99, 108)},
			{"PaleVioletRed",               new RLColor(219, 112, 147)},
			{"PaleVioletRedOne",            new RLColor(255, 130, 171)},
			{"PaleVioletRedTwo",            new RLColor(238, 121, 159)},
			{"PaleVioletRedThree",          new RLColor(205, 104, 137)},
			{"PaleVioletRedFour",           new RLColor(139,  71,  93)},
			{"LavenderBlushOne",            new RLColor(255, 240, 245)},
			{"LavenderBlushTwo",            new RLColor(238, 224, 229)},
			{"LavenderBlushThree",          new RLColor(205, 193, 197)},
			{"LavenderBlushFour",           new RLColor(139, 131, 134)},
			{"VioletRedOne",                new RLColor(255,  62, 150)},
			{"VioletRedTwo",                new RLColor(238,  58, 140)},
			{"VioletRedThree",              new RLColor(205,  50, 120)},
			{"VioletRedFour",               new RLColor(139,  34,  82)},
			{"HotPink",                     new RLColor(255, 105, 180)},
			{"HotPinkOne",                  new RLColor(255, 110, 180)},
			{"HotPinkTwo",                  new RLColor(238, 106, 167)},
			{"HotPinkThree",                new RLColor(205,  96, 144)},
			{"HotPinkFour",                 new RLColor(139,  58,  98)},
			{"Raspberry",                   new RLColor(135,  38,  87)},
			{"DeepPinkOne",                 new RLColor(255,  20, 147)},
			{"DeepPinkTwo",                 new RLColor(238,  18, 137)},
			{"DeepPinkThree",               new RLColor(205,  16, 118)},
			{"DeepPinkFour",                new RLColor(139,  10,  80)},
			{"MaroonOne",                   new RLColor(255,  52, 179)},
			{"MaroonTwo",                   new RLColor(238,  48, 167)},
			{"MaroonThree",                 new RLColor(205,  41, 144)},
			{"MaroonFour",                  new RLColor(139,  28,  98)},
			{"MediumVioletRed",             new RLColor(199,  21, 133)},
			{"VioletRed",                   new RLColor(208,  32, 144)},
			{"Orchid",                      new RLColor(218, 112, 214)},
			{"OrchidOne",                   new RLColor(255, 131, 250)},
			{"OrchidTwo",                   new RLColor(238, 122, 233)},
			{"OrchidThree",                 new RLColor(205, 105, 201)},
			{"OrchidFour",                  new RLColor(139,  71, 137)},
			{"Thistle",                     new RLColor(216, 191, 216)},
			{"ThistleOne",                  new RLColor(255, 225, 255)},
			{"ThistleTwo",                  new RLColor(238, 210, 238)},
			{"ThistleThree",				new RLColor(205, 181, 205)},
			{"ThistleFour",                 new RLColor(139, 123, 139)},
			{"PlumOne",                     new RLColor(255, 187, 255)},
			{"PlumTwo",                     new RLColor(238, 174, 238)},
			{"PlumThree",                   new RLColor(205, 150, 205)},
			{"PlumFour",                    new RLColor(139, 102, 139)},
			{"Plum",                        new RLColor(221, 160, 221)},
			{"Violet",                      new RLColor(238, 130, 238)},
			{"Magenta",                     new RLColor(255,   0, 255)},
			{"MagentaTwo",                  new RLColor(238,   0, 238)},
			{"MagentaThree",                new RLColor(205,   0, 205)},
			{"MagentaFour",                 new RLColor(139,   0, 139)},
			{"Purple",                      new RLColor(128,   0, 128)},
			{"MediumOrchid",                new RLColor(186,  85, 211)},
			{"MediumOrchidOne",             new RLColor(224, 102, 255)},
			{"MediumOrchidTwo",             new RLColor(209,  95, 238)},
			{"MediumOrchidThree",           new RLColor(180,  82, 205)},
			{"MediumOrchidFour",            new RLColor(122,  55, 139)},
			{"DarkViolet",                  new RLColor(148,   0, 211)},
			{"DarkOrchid",                  new RLColor(153,  50, 204)},
			{"DarkOrchidOne",               new RLColor(191,  62, 255)},
			{"DarkOrchidTwo",               new RLColor(178,  58, 238)},
			{"DarkOrchidThree",             new RLColor(154,  50, 205)},
			{"DarkOrchidFour",              new RLColor(104,  34, 139)},
			{"Indigo",                      new RLColor( 75,   0, 130)},
			{"BlueViolet",                  new RLColor(138,  43, 226)},
			{"PurpleOne",                   new RLColor(155,  48, 255)},
			{"PurpleTwo",                   new RLColor(145,  44, 238)},
			{"PurpleThree",                 new RLColor(125,  38, 205)},
			{"PurpleFour",                  new RLColor( 85,  26, 139)},
			{"MediumPurple",                new RLColor(147, 112, 219)},
			{"MediumPurpleOne",             new RLColor(171, 130, 255)},
			{"MediumPurpleTwo",             new RLColor(159, 121, 238)},
			{"MediumPurpleThree",           new RLColor(137, 104, 205)},
			{"MediumPurpleFour",            new RLColor( 93,  71, 139)},
			{"DarkSlateBlue",               new RLColor( 72,  61, 139)},
			{"LightSlateBlue",              new RLColor(132, 112, 255)},
			{"MediumSlateBlue",             new RLColor(123, 104, 238)},
			{"SlateBlue",                   new RLColor(106,  90, 205)},
			{"SlateBlueOne",                new RLColor(131, 111, 255)},
			{"SlateBlueTwo",                new RLColor(122, 103, 238)},
			{"SlateBlueThree",              new RLColor(105,  89, 205)},
			{"SlateBlueFour",               new RLColor( 71,  60, 139)},
			{"GhostWhite",                  new RLColor(248, 248, 255)},
			{"Lavender",                    new RLColor(230, 230, 250)},
			{"Blue",                        new RLColor(  0,   0, 255)},
			{"BlueTwo",                     new RLColor(  0,   0, 238)},
			{"BlueThree",                   new RLColor(  0,   0, 205)},
			{"BlueFour",                    new RLColor(  0,   0, 139)},
			{"Navy",                        new RLColor(  0,   0, 128)},
			{"MidnightBlue",                new RLColor( 25,  25, 112)},
			{"Cobalt",                      new RLColor( 61,  89, 171)},
			{"RoyalBlue",                   new RLColor( 65, 105, 225)},
			{"RoyalBlueOne",                new RLColor( 72, 118, 255)},
			{"RoyalBlueTwo",                new RLColor( 67, 110, 238)},
			{"RoyalBlueThree",              new RLColor( 58,  95, 205)},
			{"RoyalBlueFour",               new RLColor( 39,  64, 139)},
			{"CornFlowerBlue",              new RLColor(100, 149, 237)},
			{"LightSteelBlue",              new RLColor(176, 196, 222)},
			{"LightSteelBlueOne",           new RLColor(202, 225, 255)},
			{"LightSteelBlueTwo",           new RLColor(188, 210, 238)},
			{"LightSteelBlueThree",         new RLColor(162, 181, 205)},
			{"LightSteelBlueFour",          new RLColor(110, 123, 139)},
			{"LightSlateGray",              new RLColor(119, 136, 153)},
			{"SlateGray",                   new RLColor(112, 128, 144)},
			{"SlateGrayOne",                new RLColor(198, 226, 255)},
			{"SlateGrayTwo",                new RLColor(185, 211, 238)},
			{"SlateGrayThree",              new RLColor(159, 182, 205)},
			{"SlateGrayFour",               new RLColor(108, 123, 139)},
			{"DodgerBlueOne",               new RLColor( 30, 144, 255)},
			{"DodgerBlueTwo",               new RLColor( 28, 134, 238)},
			{"DodgerBlueThree",             new RLColor( 24, 116, 205)},
			{"DodgerBlueFour",              new RLColor( 16,  78, 139)},
			{"AliceBlue",                   new RLColor(240, 248, 255)},
			{"SteelBlue",                   new RLColor( 70, 130, 180)},
			{"SteelBlueOne",                new RLColor( 99, 184, 255)},
			{"SteelBlueTwo",                new RLColor( 92, 172, 238)},
			{"SteelBlueThree",              new RLColor( 79, 148, 205)},
			{"SteelBlueFour",               new RLColor( 54, 100, 139)},
			{"LightSkyBlue",                new RLColor(135, 206, 250)},
			{"LightSkyBlueOne",             new RLColor(176, 226, 255)},
			{"LightSkyBlueTwo",             new RLColor(164, 211, 238)},
			{"LightSkyBlueThree",           new RLColor(141, 182, 205)},
			{"LightSkyBlueFour",            new RLColor( 96, 123, 139)},
			{"SkyBlueOne",                  new RLColor(135, 206, 255)},
			{"SkyBlueTwo",                  new RLColor(126, 192, 238)},
			{"SkyBlueThree",                new RLColor(108, 166, 205)},
			{"SkyBlueFour",                 new RLColor( 74, 112, 139)},
			{"SkyBlue",                     new RLColor(135, 206, 235)},
			{"DeepSkyBlueOne",              new RLColor(  0, 191, 255)},
			{"DeepSkyBlueTwo",              new RLColor(  0, 178, 238)},
			{"DeepSkyBlueThree",            new RLColor(  0, 154, 205)},
			{"DeepSkyBlueFour",             new RLColor(  0, 104, 139)},
			{"Peacock",                     new RLColor( 51, 161, 201)},
			{"LightBlue",                   new RLColor(173, 216, 230)},
			{"LightBlueOne",                new RLColor(191, 239, 255)},
			{"LightBlueTwo",                new RLColor(178, 223, 238)},
			{"LightBlueThree",              new RLColor(154, 192, 205)},
			{"LightBlueFour",               new RLColor(104, 131, 139)},
			{"PowderBlue",                  new RLColor(176, 224, 230)},
			{"CadetBlueOne",                new RLColor(152, 245, 255)},
			{"CadetBlueTwo",                new RLColor(142, 229, 238)},
			{"CadetBlueThree",              new RLColor(122, 197, 205)},
			{"CadetBlueFour",               new RLColor( 83, 134, 139)},
			{"TurquoiseOne",                new RLColor(  0, 245, 255)},
			{"TurquoiseTwo",                new RLColor(  0, 229, 238)},
			{"TurquoiseThree",              new RLColor(  0, 197, 205)},
			{"TurquoiseFour",               new RLColor(  0, 134, 139)},
			{"CadetBlue",                   new RLColor( 95, 158, 160)},
			{"DarkTurquoise",               new RLColor(  0, 206, 209)},
			{"AzureOne",					new RLColor(240, 255, 255)},
			{"AzureTwo",					new RLColor(224, 238, 238)},
			{"AzureThree",					new RLColor(193, 205, 205)},
			{"AzureFour",					new RLColor(131, 139, 139)},
			{"LightCyanOne",				new RLColor(224, 255, 255)},
			{"LightCyanTwo",				new RLColor(209, 238, 238)},
			{"LightCyanThree",				new RLColor(180, 205, 205)},
			{"LightCyanFour",				new RLColor(122, 139, 139)},
			{"PaleTurquoiseOne",			new RLColor(187, 255, 255)},
			{"PaleTurquoiseTwo",			new RLColor(174, 238, 238)},
			{"PaleTurquoiseThree",			new RLColor(150, 205, 205)},
			{"PaleTurquoiseFour",			new RLColor(102, 139, 139)},
			{"DarkSlateGray",				new RLColor( 47,  79,  79)},
			{"DarkSlateGray 1",				new RLColor(151, 255, 255)},
			{"DarkSlateGray 2",				new RLColor(141, 238, 238)},
			{"DarkSlateGray 3",				new RLColor(121, 205, 205)},
			{"DarkSlateGray 4",				new RLColor( 82, 139, 139)},
			{"Cyan",						new RLColor(  0, 255, 255)},
			{"CyanTwo",						new RLColor(  0, 238, 238)},
			{"CyanThree",					new RLColor(  0, 205, 205)},
			{"CyanFour",					new RLColor(  0, 139, 139)},
			{"Teal",						new RLColor(  0, 128, 128)},
			{"MediumTurquoise",				new RLColor( 72, 209, 204)},
			{"LightSeaGreen",				new RLColor( 32, 178, 170)},
			{"ManganeseBlue",				new RLColor(  3, 168, 158)},
			{"Turquoise",					new RLColor( 64, 224, 208)},
			{"ColdGrey	",					new RLColor(128, 138, 135)},
			{"TurquoiseBlue",				new RLColor(  0, 199, 140)},
			{"AquamarineOne",				new RLColor(127, 255, 212)},
			{"AquamarineTwo",				new RLColor(118, 238, 198)},
			{"AquamarineThree",				new RLColor(102, 205, 170)},
			{"AquamarineFour",				new RLColor( 69, 139, 116)},
			{"MediumSpringGreen",			new RLColor(  0, 250, 154)},
			{"Mintcream",					new RLColor(245, 255, 250)},
			{"Springgreen",					new RLColor(  0, 255, 127)},
			{"SpringgreenOne",				new RLColor(  0, 238, 118)},
			{"SpringgreenTwo",				new RLColor(  0, 205, 102)},
			{"SpringgreenThree",			new RLColor(  0, 139,  69)},
			{"MediumSeaGreen",				new RLColor( 60, 179, 113)},
			{"SeaGreenOne",					new RLColor( 84, 255, 159)},
			{"SeaGreenTwo",					new RLColor( 78, 238, 148)},
			{"SeaGreenThree",				new RLColor( 67, 205, 128)},
			{"SeaGreenFour",				new RLColor( 46, 139,  87)},
			{"EmeraldGreen",				new RLColor(  0, 201,  87)},
			{"Mint",						new RLColor(189, 252, 201)},
			{"CobaltGreen",					new RLColor( 61, 145,  64)},
			{"HoneydewOne",					new RLColor(240, 255, 240)},
			{"HoneydewTwo",					new RLColor(224, 238, 224)},
			{"HoneydewThree",				new RLColor(193, 205, 193)},
			{"HoneydewFour",				new RLColor(131, 139, 131)},
			{"DarkSeaGreen",				new RLColor(143, 188, 143)},
			{"DarkSeaGreenOne",				new RLColor(193, 255, 193)},
			{"DarkSeaGreenTwo",				new RLColor(180, 238, 180)},
			{"DarkSeaGreenThree",			new RLColor(155, 205, 155)},
			{"DarkSeaGreenFour",			new RLColor(105, 139, 105)},
			{"PaleGreen",					new RLColor(152, 251, 152)},
			{"PaleGreenOne",				new RLColor(154, 255, 154)},
			{"PaleGreenTwo",				new RLColor(144, 238, 144)},
			{"PaleGreenThree",				new RLColor(124, 205, 124)},
			{"PaleGreenFour",				new RLColor( 84, 139,  84)},

			{"limegreen limegreen",				new RLColor( 50, 205,  50)},
			{"forestgreen forestgreen",				new RLColor( 34, 139,  34)},
			{"green 1 (lime*)",				new RLColor(  0, 255,   0)},
			{"green 2",				new RLColor(  0, 238,   0)},
			{"green 3",				new RLColor(  0, 205,   0)},
			{"green 4",				new RLColor(  0, 139,   0)},
			{"green* green*",				new RLColor(  0, 128,   0)},
			{"darkgreen       darkgreen",				new RLColor(  0, 100,   0)},
			{"sapgreen        sapgreen",				new RLColor( 48, 128,  20)},
			{"lawngreen       lawngreen",				new RLColor(124, 252,   0)},
			{"chartreuse 1 (chartreuse)",				new RLColor(127, 255,   0)},
			{"chartreuse 2",				new RLColor(118, 238,   0)},
			{"chartreuse 3",				new RLColor(102, 205,   0)},
			{"chartreuse 4",				new RLColor( 69, 139,   0)},
			{"greenyellow greenyellow",				new RLColor(173, 255,  47)},
			{"darkolivegreen 1",				new RLColor(202, 255, 112)},
			{"darkolivegreen 2",				new RLColor(188, 238, 104)},
			{"darkolivegreen 3",				new RLColor(162, 205,  90)},
			{"darkolivegreen 4",				new RLColor(110, 139,  61)},
			{"darkolivegreen darkolivegreen",				new RLColor( 85, 107,  47)},
			{"olivedrab olivedrab",				new RLColor(107, 142,  35)},
			{"olivedrab 1",				new RLColor(192, 255,  62)},
			{"olivedrab 2",				new RLColor(179, 238,  58)},
			{"olivedrab 3 (yellowgreen)",				new RLColor(154, 205,  50)},
			{"olivedrab 4",				new RLColor(105, 139,  34)},
			{"ivory 1 (ivory)",				new RLColor(255, 255, 240)},
			{"ivory 2",				new RLColor(238, 238, 224)},
			{"ivory 3",				new RLColor(205, 205, 193)},
			{"ivory 4",				new RLColor(139, 139, 131)},
			{"beige beige",				new RLColor(245, 245, 220)},
			{"lightyellow 1 (lightyellow)",				new RLColor(255, 255, 224)},
			{"lightyellow 2",				new RLColor(238, 238, 209)},
			{"lightyellow 3",				new RLColor(205, 205, 180)},
			{"lightyellow 4",				new RLColor(139, 139, 122)},
			{"lightgoldenrodyellow lightgoldenrodyellow",				new RLColor(250, 250, 210)},
			{"yellow 1 (yellow*)",				new RLColor(255, 255,   0)},
			{"yellow 2",				new RLColor(238, 238,   0)},
			{"yellow 3",				new RLColor(205, 205,   0)},
			{"yellow 4",				new RLColor(139, 139,   0)},
			{"warmgrey warmgrey",				new RLColor(128, 128, 105)},
			{"olive* olive*",				new RLColor(128, 128,   0)},
			{"darkkhaki       darkkhaki",				new RLColor(189, 183, 107)},
			{"khaki 1",				new RLColor(255, 246, 143)},
			{"khaki 2",				new RLColor(238, 230, 133)},
			{"khaki 3",				new RLColor(205, 198, 115)},
			{"khaki 4",				new RLColor(139, 134,  78)},
			{"khaki khaki",				new RLColor(240, 230, 140)},
			{"palegoldenrod palegoldenrod",				new RLColor(238, 232, 170)},
			{"lemonchiffon 1 (lemonchiffon)",				new RLColor(255, 250, 205)},
			{"lemonchiffon 2",				new RLColor(238, 233, 191)},
			{"lemonchiffon 3",				new RLColor(205, 201, 165)},
			{"lemonchiffon 4",				new RLColor(139, 137, 112)},
			{"lightgoldenrod 1",				new RLColor(255, 236, 139)},
			{"lightgoldenrod 2",				new RLColor(238, 220, 130)},
			{"lightgoldenrod 3",				new RLColor(205, 190, 112)},
			{"lightgoldenrod 4",				new RLColor(139, 129,  76)},
			{"banana banana",				new RLColor(227, 207,  87)},
			{"gold 1 (gold)",				new RLColor(255, 215,   0)},
			{"gold 2",				new RLColor(238, 201,   0)},
			{"gold 3",				new RLColor(205, 173,   0)},
			{"gold 4",				new RLColor(139, 117,   0)},
			{"cornsilk 1 (cornsilk)",				new RLColor(255, 248, 220)},
			{"cornsilk 2",				new RLColor(238, 232, 205)},
			{"cornsilk 3",				new RLColor(205, 200, 177)},
			{"cornsilk 4",				new RLColor(139, 136, 120)},
			{"goldenrod goldenrod",				new RLColor(218, 165,  32)},
			{"goldenrod 1",				new RLColor(255, 193,  37)},
			{"goldenrod 2",				new RLColor(238, 180,  34)},
			{"goldenrod 3",				new RLColor(205, 155,  29)},
			{"goldenrod 4",				new RLColor(139, 105,  20)},
			{"darkgoldenrod darkgoldenrod",				new RLColor(184, 134,  11)},
			{"darkgoldenrod 1",				new RLColor(255, 185,  15)},
			{"darkgoldenrod 2",				new RLColor(238, 173,  14)},
			{"darkgoldenrod 3",				new RLColor(205, 149,  12)},
			{"darkgoldenrod 4",				new RLColor(139, 101,   8)},
			{"orange 1 (orange)",				new RLColor(255, 165,   0)},
			{"orange 2",				new RLColor(238, 154,   0)},
			{"orange 3",				new RLColor(205, 133,   0)},
			{"orange 4",				new RLColor(139,  90,   0)},
			{"floralwhite floralwhite",				new RLColor(255, 250, 240)},
			{"oldlace oldlace",				new RLColor(253, 245, 230)},
			{"wheat wheat",				new RLColor(245, 222, 179)},
			{"wheat 1",				new RLColor(255, 231, 186)},
			{"wheat 2",				new RLColor(238, 216, 174)},
			{"wheat 3",				new RLColor(205, 186, 150)},
			{"wheat 4",				new RLColor(139, 126, 102)},
			{"moccasin moccasin",				new RLColor(255, 228, 181)},
			{"papayawhip papayawhip",				new RLColor(255, 239, 213)},
			{"blanchedalmond blanchedalmond",				new RLColor(255, 235, 205)},
			{"navajowhite 1 (navajowhite)",				new RLColor(255, 222, 173)},
			{"navajowhite 2",				new RLColor(238, 207, 161)},
			{"navajowhite 3",				new RLColor(205, 179, 139)},
			{"navajowhite 4",				new RLColor(139, 121,  94)},
			{"eggshell eggshell",				new RLColor(252, 230, 201)},
			{"tan tan",				new RLColor(210, 180, 140)},
			{"brick brick",				new RLColor(156, 102,  31)},
			{"cadmiumyellow cadmiumyellow",				new RLColor(255, 153,  18)},
			{"antiquewhite antiquewhite",				new RLColor(250, 235, 215)},
			{"antiquewhite 1",				new RLColor(255, 239, 219)},
			{"antiquewhite 2",				new RLColor(238, 223, 204)},
			{"antiquewhite 3",				new RLColor(205, 192, 176)},
			{"antiquewhite 4",				new RLColor(139, 131, 120)},
			{"burlywood burlywood",				new RLColor(222, 184, 135)},
			{"burlywood 1",				new RLColor(255, 211, 155)},
			{"burlywood 2",				new RLColor(238, 197, 145)},
			{"burlywood 3",				new RLColor(205, 170, 125)},
			{"burlywood 4",				new RLColor(139, 115,  85)},
			{"bisque 1 (bisque)",				new RLColor(255, 228, 196)},
			{"bisque 2",				new RLColor(238, 213, 183)},
			{"bisque 3",				new RLColor(205, 183, 158)},
			{"bisque 4",				new RLColor(139, 125, 107)},
			{"melon melon",				new RLColor(227, 168, 105)},
			{"carrot carrot",				new RLColor(237, 145,  33)},
			{"darkorange darkorange",				new RLColor(255, 140,   0)},
			{"darkorange 1",				new RLColor(255, 127,   0)},
			{"darkorange 2",				new RLColor(238, 118,   0)},
			{"darkorange 3",				new RLColor(205, 102,   0)},
			{"darkorange 4",				new RLColor(139,  69,   0)},
			{"orange orange",				new RLColor(255, 128,   0)},
			{"tan 1",				new RLColor(255, 165,  79)},
			{"tan 2",				new RLColor(238, 154,  73)},
			{"tan 3 (peru)",				new RLColor(205, 133,  63)},
			{"tan 4",				new RLColor(139,  90,  43)},
			{"linen linen",				new RLColor(250, 240, 230)},
			{"peachpuff 1 (peachpuff)",				new RLColor(255, 218, 185)},
			{"peachpuff 2",				new RLColor(238, 203, 173)},
			{"peachpuff 3",				new RLColor(205, 175, 149)},
			{"peachpuff 4",				new RLColor(139, 119, 101)},
			{"seashell 1 (seashell)",				new RLColor(255, 245, 238)},
			{"seashell 2",				new RLColor(238, 229, 222)},
			{"seashell 3",				new RLColor(205, 197, 191)},
			{"seashell 4",				new RLColor(139, 134, 130)},
			{"sandybrown sandybrown",				new RLColor(244, 164,  96)},
			{"rawsienna rawsienna",				new RLColor(199,  97,  20)},
			{"chocolate chocolate",				new RLColor(210, 105,  30)},
			{"chocolate 1",				new RLColor(255, 127,  36)},
			{"chocolate 2",				new RLColor(238, 118,  33)},
			{"chocolate 3",				new RLColor(205, 102,  29)},
			{"chocolate 4 (saddlebrown)",				new RLColor(139,  69,  19)},
			{"ivoryblack ivoryblack",				new RLColor( 41,  36,  33)},
			{"flesh flesh",				new RLColor(255, 125,  64)},
			{"cadmiumorange cadmiumorange",				new RLColor(255,  97,   3)},
			{"burntsienna burntsienna",				new RLColor(138,  54,  15)},
			{"sienna sienna",				new RLColor(160,  82,  45)},
			{"sienna 1",				new RLColor(255, 130,  71)},
			{"sienna 2",				new RLColor(238, 121,  66)},
			{"sienna 3",				new RLColor(205, 104,  57)},
			{"sienna 4",				new RLColor(139,  71,  38)},
			{"lightsalmon 1 (lightsalmon)",				new RLColor(255, 160, 122)},
			{"lightsalmon 2",				new RLColor(238, 149, 114)},
			{"lightsalmon 3",				new RLColor(205, 129,  98)},
			{"lightsalmon 4",				new RLColor(139,  87,  66)},
			{"coral coral",				new RLColor(255, 127,  80)},
			{"orangered 1 (orangered)",				new RLColor(255,  69,   0)},
			{"orangered 2",				new RLColor(238,  64,   0)},
			{"orangered 3",				new RLColor(205,  55,   0)},
			{"orangered 4",				new RLColor(139,  37,   0)},
			{"sepia sepia",				new RLColor( 94,  38,  18)},
			{"darksalmon darksalmon",				new RLColor(233, 150, 122)},
			{"salmon 1",				new RLColor(255, 140, 105)},
			{"salmon 2",				new RLColor(238, 130,  98)},
			{"salmon 3",				new RLColor(205, 112,  84)},
			{"salmon 4",				new RLColor(139,  76,  57)},
			{"coral 1",				new RLColor(255, 114,  86)},
			{"coral 2",				new RLColor(238, 106,  80)},
			{"coral 3",				new RLColor(205,  91,  69)},
			{"coral 4",				new RLColor(139,  62,  47)},
			{"burntumber burntumber",				new RLColor(138,  51,  36)},
			{"tomato 1 (tomato)",				new RLColor(255,  99,  71)},
			{"tomato 2",				new RLColor(238,  92,  66)},
			{"tomato 3",				new RLColor(205,  79,  57)},
			{"tomato 4",				new RLColor(139,  54,  38)},
			{"salmon salmon",				new RLColor(250, 128, 114)},
			{"mistyrose 1 (mistyrose)",				new RLColor(255, 228, 225)},
			{"mistyrose 2",				new RLColor(238, 213, 210)},
			{"mistyrose 3",				new RLColor(205, 183, 181)},
			{"mistyrose 4",				new RLColor(139, 125, 123)},
			{"snow 1 (snow)",				new RLColor(255, 250, 250)},
			{"snow 2",				new RLColor(238, 233, 233)},
			{"snow 3",				new RLColor(205, 201, 201)},
			{"snow 4",				new RLColor(139, 137, 137)},
			{"rosybrown rosybrown",				new RLColor(188, 143, 143)},
			{"rosybrown 1",				new RLColor(255, 193, 193)},
			{"rosybrown 2",				new RLColor(238, 180, 180)},
			{"rosybrown 3",				new RLColor(205, 155, 155)},
			{"rosybrown 4",				new RLColor(139, 105, 105)},
			{"lightcoral lightcoral",				new RLColor(240, 128, 128)},
			{"indianred indianred",				new RLColor(205,  92,  92)},
			{"indianred 1",				new RLColor(255, 106, 106)},
			{"indianred 2",				new RLColor(238,  99,  99)},
			{"indianred 4",				new RLColor(139,  58,  58)},
			{"indianred 3",				new RLColor(205,  85,  85)},
			{"brown brown",				new RLColor(165,  42,  42)},
			{"brown 1",				new RLColor(255,  64,  64)},
			{"brown 2",				new RLColor(238,  59,  59)},
			{"brown 3",				new RLColor(205,  51,  51)},
			{"brown 4",				new RLColor(139,  35,  35)},
			{"firebrick firebrick",				new RLColor(178,  34,  34)},
			{"firebrick 1",				new RLColor(255,  48,  48)},
			{"firebrick 2",				new RLColor(238,  44,  44)},
			{"firebrick 3",				new RLColor(205,  38,  38)},
			{"firebrick 4",				new RLColor(139,  26,  26)},
			{"red 1 (red*)",				new RLColor(255,   0,   0)},
			{"red 2",				new RLColor(238,   0,   0)},
			{"red 3",				new RLColor(205,   0,   0)},
			{"red 4 (darkred)",				new RLColor(139,   0,   0)},
			{"maroon* maroon*",				new RLColor(128,   0,   0)},
			{"sgi beet sgi beet",				new RLColor(142,  56, 142)},
			{"sgi slateblue sgi slateblue",				new RLColor(113, 113, 198)},
			{"sgi lightblue sgi lightblue",				new RLColor(125, 158, 192)},
			{"sgi teal sgi teal",				new RLColor( 56, 142, 142)},
			{"sgi chartreuse sgi chartreuse",				new RLColor(113, 198, 113)},
			{"sgi olivedrab sgi olivedrab",				new RLColor(142, 142,  56)},
			{"sgi brightgray sgi brightgray",				new RLColor(197, 193, 170)},
			{"sgi salmon sgi salmon",				new RLColor(198, 113, 113)},
			{"sgi darkgray sgi darkgray",				new RLColor( 85,  85,  85)},
			{"sgi gray 12",				new RLColor( 30,  30,  30)},
			{"sgi gray 16",				new RLColor( 40,  40,  40)},
			{"sgi gray 32",				new RLColor( 81,  81,  81)},
			{"sgi gray 36",				new RLColor( 91,  91,  91)},
			{"sgi gray 52",				new RLColor(132, 132, 132)},
			{"sgi gray 56",				new RLColor(142, 142, 142)},
			{"sgi lightgray       sgi lightgray",				new RLColor(170, 170, 170)},
			{"sgi gray 72",				new RLColor(183, 183, 183)},
			{"sgi gray 76",				new RLColor(193, 193, 193)},
			{"sgi gray 92",				new RLColor(234, 234, 234)},
			{"sgi gray 96",				new RLColor(244, 244, 244)},
			{"white* white*",				new RLColor(255, 255, 255)},
			{"white smoke(gray 96)       white smoke(gray 96)",				new RLColor(245, 245, 245)},
			{"gainsboro gainsboro",				new RLColor(220, 220, 220)},
			{"lightgrey lightgrey",				new RLColor(211, 211, 211)},
			{"silver* silver*",				new RLColor(192, 192, 192)},
			{"darkgray        darkgray",				new RLColor(169, 169, 169)},
			{"gray* gray*",				new RLColor(128, 128, 128)},
			{"dimgray(gray 42)       dimgray(gray 42)",				new RLColor(105, 105, 105)},
			{"black* black*",				new RLColor(  0,   0,   0)},
			{"gray 99",				new RLColor(252, 252, 252)},
			{"gray 98",				new RLColor(250, 250, 250)},
			{"gray 97",				new RLColor(247, 247, 247)},
			{"white smoke(gray 96)       white smoke(gray 96)",				new RLColor(245, 245, 245)},
			{"gray 95",				new RLColor(242, 242, 242)},
			{"gray 94",				new RLColor(240, 240, 240)},
			{"gray 93",				new RLColor(237, 237, 237)},
			{"gray 92",				new RLColor(235, 235, 235)},
			{"gray 91",				new RLColor(232, 232, 232)},
			{"gray 90",				new RLColor(229, 229, 229)},
			{"gray 89",				new RLColor(227, 227, 227)},
			{"gray 88",				new RLColor(224, 224, 224)},
			{"gray 87",				new RLColor(222, 222, 222)},
			{"gray 86",				new RLColor(219, 219, 219)},
			{"gray 85",				new RLColor(217, 217, 217)},
			{"gray 84",				new RLColor(214, 214, 214)},
			{"gray 83",				new RLColor(212, 212, 212)},
			{"gray 82",				new RLColor(209, 209, 209)},
			{"gray 81",				new RLColor(207, 207, 207)},
			{"gray 80",				new RLColor(204, 204, 204)},
			{"gray 79",				new RLColor(201, 201, 201)},
			{"gray 78",				new RLColor(199, 199, 199)},
			{"gray 77",				new RLColor(196, 196, 196)},
			{"gray 76",				new RLColor(194, 194, 194)},
			{"gray 75",				new RLColor(191, 191, 191)},
			{"gray 74",				new RLColor(189, 189, 189)},
			{"gray 73",				new RLColor(186, 186, 186)},
			{"gray 72",				new RLColor(184, 184, 184)},
			{"gray 71",				new RLColor(181, 181, 181)},
			{"gray 70",				new RLColor(179, 179, 179)},
			{"gray 69",				new RLColor(176, 176, 176)},
			{"gray 68",				new RLColor(173, 173, 173)},
			{"gray 67",				new RLColor(171, 171, 171)},
			{"gray 66",				new RLColor(168, 168, 168)},
			{"gray 65",				new RLColor(166, 166, 166)},
			{"gray 64",				new RLColor(163, 163, 163)},
			{"gray 63",				new RLColor(161, 161, 161)},
			{"gray 62",				new RLColor(158, 158, 158)},
			{"gray 61",				new RLColor(156, 156, 156)},
			{"gray 60",				new RLColor(153, 153, 153)},
			{"gray 59",				new RLColor(150, 150, 150)},
			{"gray 58",				new RLColor(148, 148, 148)},
			{"gray 57",				new RLColor(145, 145, 145)},
			{"gray 56",				new RLColor(143, 143, 143)},
			{"gray 55",				new RLColor(140, 140, 140)},
			{"gray 54",				new RLColor(138, 138, 138)},
			{"gray 53",				new RLColor(135, 135, 135)},
			{"gray 52",				new RLColor(133, 133, 133)},
			{"gray 51",				new RLColor(130, 130, 130)},
			{"gray 50",				new RLColor(127, 127, 127)},
			{"gray 49",				new RLColor(125, 125, 125)},
			{"gray 48",				new RLColor(122, 122, 122)},
			{"gray 47",				new RLColor(120, 120, 120)},
			{"gray 46",				new RLColor(117, 117, 117)},
			{"gray 45",				new RLColor(115, 115, 115)},
			{"gray 44",				new RLColor(112, 112, 112)},
			{"gray 43",				new RLColor(110, 110, 110)},
			{"gray 42",				new RLColor(107, 107, 107)},
			{"dimgray(gray 42)       dimgray(gray 42)",				new RLColor(105, 105, 105)},
			{"gray 40",				new RLColor(102, 102, 102)},
			{"gray 39",				new RLColor( 99,  99,  99)},
			{"gray 38",				new RLColor( 97,  97,  97)},
			{"gray 37",				new RLColor( 94,  94,  94)},
			{"gray 36",				new RLColor( 92,  92,  92)},
			{"gray 35",				new RLColor( 89,  89,  89)},
			{"gray 34",				new RLColor( 87,  87,  87)},
			{"gray 33",				new RLColor( 84,  84,  84)},
			{"gray 32",				new RLColor( 82,  82,  82)},
			{"gray 31",				new RLColor( 79,  79,  79)},
			{"gray 30",				new RLColor( 77,  77,  77)},
			{"gray 29",				new RLColor( 74,  74,  74)},
			{"gray 28",				new RLColor( 71,  71,  71)},
			{"gray 27",				new RLColor( 69,  69,  69)},
			{"gray 26",				new RLColor( 66,  66,  66)},
			{"gray 25",				new RLColor( 64,  64,  64)},
			{"gray 24",				new RLColor( 61,  61,  61)},
			{"gray 23",				new RLColor( 59,  59,  59)},
			{"gray 22",				new RLColor( 56,  56,  56)},
			{"gray 21",				new RLColor( 54,  54,  54)},
			{"gray 20",				new RLColor( 51,  51,  51)},
			{"gray 19",				new RLColor( 48,  48,  48)},
			{"gray 18",				new RLColor( 46,  46,  46)},
			{"gray 17",				new RLColor( 43,  43,  43)},
			{"gray 16",				new RLColor( 41,  41,  41)},
			{"gray 15",				new RLColor( 38,  38,  38)},
			{"gray 14",				new RLColor( 36,  36,  36)},
			{"gray 13",				new RLColor( 33,  33,  33)},
			{"gray 12",				new RLColor( 31,  31,  31)},
			{"gray 11",				new RLColor( 28,  28,  28)},
			{"gray 10",				new RLColor( 26,  26,  26)},
			{"gray 9",				new RLColor( 23,  23,  23)},
			{"gray 8",				new RLColor( 20,  20,  20)},
			{"gray 7",				new RLColor( 18,  18,  18)},
			{"gray 6",				new RLColor( 15,  15,  15)},
			{"gray 5",				new RLColor( 13,  13,  13)},
			{"gray 4",				new RLColor( 10,  10,  10)},
			{"gray 3",				new RLColor(  8,   8,   8)},
			{"gray 2",				new RLColor(  5,   5,   5)},
			{"gray 1",				new RLColor(  3,   3,   3)},
			{"Black",                   new RLColor(0, 0, 0)},
			{"White",                   new RLColor(255, 255, 255)},
			{"Silver",                  new RLColor(190, 190, 190)}
		};

		public static RLColor GetColor(string colorName)
		{
			if (colors.ContainsKey(colorName))
				return colors[colorName];
			ErrorLogger.AddDebugText("Unknown color name: " + colorName);
			return colors["Black"];
		}
	}
}
/*
azure 1 (azure)	 	azure 1 (azure)	#F0FFFF	240	255	255	16777200
azure 2	 	azure 2	#E0EEEE	224	238	238	15658720
azure 3	 	azure 3	#C1CDCD	193	205	205	13487553
azure 4	 	azure 4	#838B8B	131	139	139	9145219
lightcyan 1 (lightcyan)	 	lightcyan 1 (lightcyan)	#E0FFFF	224	255	255	16777184
lightcyan 2	 	lightcyan 2	#D1EEEE	209	238	238	15658705
lightcyan 3	 	lightcyan 3	#B4CDCD	180	205	205	13487540
lightcyan 4	 	lightcyan 4	#7A8B8B	122	139	139	9145210
paleturquoise 1	 	paleturquoise 1	#BBFFFF	187	255	255	16777147
paleturquoise 2 (paleturquoise)	 	paleturquoise 2 (paleturquoise)	#AEEEEE	174	238	238	15658670
paleturquoise 3	 	paleturquoise 3	#96CDCD	150	205	205	13487510
paleturquoise 4	 	paleturquoise 4	#668B8B	102	139	139	9145190
darkslategray darkslategray	#2F4F4F	47	79	79	5197615
darkslategray 1	 	darkslategray 1	#97FFFF	151	255	255	16777111
darkslategray 2	 	darkslategray 2	#8DEEEE	141	238	238	15658637
darkslategray 3	 	darkslategray 3	#79CDCD	121	205	205	13487481
darkslategray 4	 	darkslategray 4	#528B8B	82	139	139	9145170
cyan / aqua* cyan / aqua*	#00FFFF	0	255	255	16776960
cyan 2	 	cyan 2	#00EEEE	0	238	238	15658496
cyan 3	 	cyan 3	#00CDCD	0	205	205	13487360
cyan 4 (darkcyan)	 	cyan 4 (darkcyan)	#008B8B	0	139	139	9145088
teal* teal*	#008080	0	128	128	8421376
mediumturquoise     mediumturquoise	#48D1CC	72	209	204	13422920
lightseagreen       lightseagreen	#20B2AA	32	178	170	11186720
manganeseblue       manganeseblue	#03A89E	3	168	158	10397699
turquoise       turquoise	#40E0D0	64	224	208	13688896
coldgrey        coldgrey	#808A87	128	138	135	8882816
turquoiseblue       turquoiseblue	#00C78C	0	199	140	9225984
aquamarine 1 (aquamarine)	 	aquamarine 1 (aquamarine)	#7FFFD4	127	255	212	13959039
aquamarine 2	 	aquamarine 2	#76EEC6	118	238	198	13037174
aquamarine 3 (mediumaquamarine)	 	aquamarine 3 (mediumaquamarine)	#66CDAA	102	205	170	11193702
aquamarine 4	 	aquamarine 4	#458B74	69	139	116	7637829
mediumspringgreen mediumspringgreen	#00FA9A	0	250	154	10156544
mintcream mintcream	#F5FFFA	245	255	250	16449525
springgreen springgreen	#00FF7F	0	255	127	8388352
springgreen 1	 	springgreen 1	#00EE76	0	238	118	7794176
springgreen 2	 	springgreen 2	#00CD66	0	205	102	6737152
springgreen 3	 	springgreen 3	#008B45	0	139	69	4557568
mediumseagreen mediumseagreen	#3CB371	60	179	113	7451452
seagreen 1	 	seagreen 1	#54FF9F	84	255	159	10485588
seagreen 2	 	seagreen 2	#4EEE94	78	238	148	9760334
seagreen 3	 	seagreen 3	#43CD80	67	205	128	8441155
seagreen 4 (seagreen)	 	seagreen 4 (seagreen)	#2E8B57	46	139	87	5737262
emeraldgreen emeraldgreen	#00C957	0	201	87	5753088
mint mint	#BDFCC9	189	252	201	13237437
cobaltgreen cobaltgreen	#3D9140	61	145	64	4231485
honeydew 1 (honeydew)	 	honeydew 1 (honeydew)	#F0FFF0	240	255	240	15794160
honeydew 2	 	honeydew 2	#E0EEE0	224	238	224	14741216
honeydew 3	 	honeydew 3	#C1CDC1	193	205	193	12701121
honeydew 4	 	honeydew 4	#838B83	131	139	131	8620931
darkseagreen darkseagreen	#8FBC8F	143	188	143	9419919
darkseagreen 1	 	darkseagreen 1	#C1FFC1	193	255	193	12713921
darkseagreen 2	 	darkseagreen 2	#B4EEB4	180	238	180	11857588
darkseagreen 3	 	darkseagreen 3	#9BCD9B	155	205	155	10210715
darkseagreen 4	 	darkseagreen 4	#698B69	105	139	105	6916969
palegreen palegreen	#98FB98	152	251	152	10025880
palegreen 1	 	palegreen 1	#9AFF9A	154	255	154	10157978
palegreen 2 (lightgreen)	 	palegreen 2 (lightgreen)	#90EE90	144	238	144	9498256
palegreen 3	 	palegreen 3	#7CCD7C	124	205	124	8179068
palegreen 4	 	palegreen 4	#548B54	84	139	84	5540692
limegreen limegreen	#32CD32	50	205	50	3329330
forestgreen forestgreen	#228B22	34	139	34	2263842
green 1 (lime*)	 	green 1 (lime*)	#00FF00	0	255	0	65280
green 2	 	green 2	#00EE00	0	238	0	60928
green 3	 	green 3	#00CD00	0	205	0	52480
green 4	 	green 4	#008B00	0	139	0	35584
green* green*	#008000	0	128	0	32768
darkgreen       darkgreen	#006400	0	100	0	25600
sapgreen        sapgreen	#308014	48	128	20	1343536
lawngreen       lawngreen	#7CFC00	124	252	0	64636
chartreuse 1 (chartreuse)	 	chartreuse 1 (chartreuse)	#7FFF00	127	255	0	65407
chartreuse 2	 	chartreuse 2	#76EE00	118	238	0	61046
chartreuse 3	 	chartreuse 3	#66CD00	102	205	0	52582
chartreuse 4	 	chartreuse 4	#458B00	69	139	0	35653
greenyellow greenyellow	#ADFF2F	173	255	47	3145645
darkolivegreen 1	 	darkolivegreen 1	#CAFF70	202	255	112	7405514
darkolivegreen 2	 	darkolivegreen 2	#BCEE68	188	238	104	6876860
darkolivegreen 3	 	darkolivegreen 3	#A2CD5A	162	205	90	5950882
darkolivegreen 4	 	darkolivegreen 4	#6E8B3D	110	139	61	4033390
darkolivegreen darkolivegreen	#556B2F	85	107	47	3107669
olivedrab olivedrab	#6B8E23	107	142	35	2330219
olivedrab 1	 	olivedrab 1	#C0FF3E	192	255	62	4128704
olivedrab 2	 	olivedrab 2	#B3EE3A	179	238	58	3862195
olivedrab 3 (yellowgreen)	 	olivedrab 3 (yellowgreen)	#9ACD32	154	205	50	3329434
olivedrab 4	 	olivedrab 4	#698B22	105	139	34	2263913
ivory 1 (ivory)	 	ivory 1 (ivory)	#FFFFF0	255	255	240	15794175
ivory 2	 	ivory 2	#EEEEE0	238	238	224	14741230
ivory 3	 	ivory 3	#CDCDC1	205	205	193	12701133
ivory 4	 	ivory 4	#8B8B83	139	139	131	8620939
beige beige	#F5F5DC	245	245	220	14480885
lightyellow 1 (lightyellow)	 	lightyellow 1 (lightyellow)	#FFFFE0	255	255	224	14745599
lightyellow 2	 	lightyellow 2	#EEEED1	238	238	209	13758190
lightyellow 3	 	lightyellow 3	#CDCDB4	205	205	180	11849165
lightyellow 4	 	lightyellow 4	#8B8B7A	139	139	122	8031115
lightgoldenrodyellow lightgoldenrodyellow	#FAFAD2	250	250	210	13826810
yellow 1 (yellow*)	 	yellow 1 (yellow*)	#FFFF00	255	255	0	65535
yellow 2	 	yellow 2	#EEEE00	238	238	0	61166
yellow 3	 	yellow 3	#CDCD00	205	205	0	52685
yellow 4	 	yellow 4	#8B8B00	139	139	0	35723
warmgrey warmgrey	#808069	128	128	105	6914176
olive* olive*	#808000	128	128	0	32896
darkkhaki       darkkhaki	#BDB76B	189	183	107	7059389
khaki 1	 	khaki 1	#FFF68F	255	246	143	9434879
khaki 2	 	khaki 2	#EEE685	238	230	133	8775406
khaki 3	 	khaki 3	#CDC673	205	198	115	7587533
khaki 4	 	khaki 4	#8B864E	139	134	78	5146251
khaki khaki	#F0E68C	240	230	140	9234160
palegoldenrod palegoldenrod	#EEE8AA	238	232	170	11200750
lemonchiffon 1 (lemonchiffon)	 	lemonchiffon 1 (lemonchiffon)	#FFFACD	255	250	205	13499135
lemonchiffon 2	 	lemonchiffon 2	#EEE9BF	238	233	191	12577262
lemonchiffon 3	 	lemonchiffon 3	#CDC9A5	205	201	165	10865101
lemonchiffon 4	 	lemonchiffon 4	#8B8970	139	137	112	7375243
lightgoldenrod 1	 	lightgoldenrod 1	#FFEC8B	255	236	139	9170175
lightgoldenrod 2	 	lightgoldenrod 2	#EEDC82	238	220	130	8576238
lightgoldenrod 3	 	lightgoldenrod 3	#CDBE70	205	190	112	7388877
lightgoldenrod 4	 	lightgoldenrod 4	#8B814C	139	129	76	5013899
banana banana	#E3CF57	227	207	87	5754851
gold 1 (gold)	 	gold 1 (gold)	#FFD700	255	215	0	55295
gold 2	 	gold 2	#EEC900	238	201	0	51694
gold 3	 	gold 3	#CDAD00	205	173	0	44493
gold 4	 	gold 4	#8B7500	139	117	0	30091
cornsilk 1 (cornsilk)	 	cornsilk 1 (cornsilk)	#FFF8DC	255	248	220	14481663
cornsilk 2	 	cornsilk 2	#EEE8CD	238	232	205	13494510
cornsilk 3	 	cornsilk 3	#CDC8B1	205	200	177	11651277
cornsilk 4	 	cornsilk 4	#8B8878	139	136	120	7899275
goldenrod goldenrod	#DAA520	218	165	32	2139610
goldenrod 1	 	goldenrod 1	#FFC125	255	193	37	2474495
goldenrod 2	 	goldenrod 2	#EEB422	238	180	34	2274542
goldenrod 3	 	goldenrod 3	#CD9B1D	205	155	29	1940429
goldenrod 4	 	goldenrod 4	#8B6914	139	105	20	1337739
darkgoldenrod darkgoldenrod	#B8860B	184	134	11	755384
darkgoldenrod 1	 	darkgoldenrod 1	#FFB90F	255	185	15	1030655
darkgoldenrod 2	 	darkgoldenrod 2	#EEAD0E	238	173	14	962030
darkgoldenrod 3	 	darkgoldenrod 3	#CD950C	205	149	12	824781
darkgoldenrod 4	 	darkgoldenrod 4	#8B6508	139	101	8	550283
orange 1 (orange)	 	orange 1 (orange)	#FFA500	255	165	0	42495
orange 2	 	orange 2	#EE9A00	238	154	0	39662
orange 3	 	orange 3	#CD8500	205	133	0	34253
orange 4	 	orange 4	#8B5A00	139	90	0	23179
floralwhite floralwhite	#FFFAF0	255	250	240	15792895
oldlace oldlace	#FDF5E6	253	245	230	15136253
wheat wheat	#F5DEB3	245	222	179	11788021
wheat 1	 	wheat 1	#FFE7BA	255	231	186	12249087
wheat 2	 	wheat 2	#EED8AE	238	216	174	11458798
wheat 3	 	wheat 3	#CDBA96	205	186	150	9878221
wheat 4	 	wheat 4	#8B7E66	139	126	102	6717067
moccasin moccasin	#FFE4B5	255	228	181	11920639
papayawhip papayawhip	#FFEFD5	255	239	213	14020607
blanchedalmond blanchedalmond	#FFEBCD	255	235	205	13495295
navajowhite 1 (navajowhite)	 	navajowhite 1 (navajowhite)	#FFDEAD	255	222	173	11394815
navajowhite 2	 	navajowhite 2	#EECFA1	238	207	161	10604526
navajowhite 3	 	navajowhite 3	#CDB38B	205	179	139	9155533
navajowhite 4	 	navajowhite 4	#8B795E	139	121	94	6191499
eggshell eggshell	#FCE6C9	252	230	201	13231868
tan tan	#D2B48C	210	180	140	9221330
brick brick	#9C661F	156	102	31	2057884
cadmiumyellow cadmiumyellow	#FF9912	255	153	18	1219071
antiquewhite antiquewhite	#FAEBD7	250	235	215	14150650
antiquewhite 1	 	antiquewhite 1	#FFEFDB	255	239	219	14413823
antiquewhite 2	 	antiquewhite 2	#EEDFCC	238	223	204	13426670
antiquewhite 3	 	antiquewhite 3	#CDC0B0	205	192	176	11583693
antiquewhite 4	 	antiquewhite 4	#8B8378	139	131	120	7897995
burlywood burlywood	#DEB887	222	184	135	8894686
burlywood 1	 	burlywood 1	#FFD39B	255	211	155	10212351
burlywood 2	 	burlywood 2	#EEC591	238	197	145	9553390
burlywood 3	 	burlywood 3	#CDAA7D	205	170	125	8235725
burlywood 4	 	burlywood 4	#8B7355	139	115	85	5600139
bisque 1 (bisque)	 	bisque 1 (bisque)	#FFE4C4	255	228	196	12903679
bisque 2	 	bisque 2	#EED5B7	238	213	183	12047854
bisque 3	 	bisque 3	#CDB79E	205	183	158	10401741
bisque 4	 	bisque 4	#8B7D6B	139	125	107	7044491
melon melon	#E3A869	227	168	105	6924515
carrot carrot	#ED9121	237	145	33	2200045
darkorange darkorange	#FF8C00	255	140	0	36095
darkorange 1	 	darkorange 1	#FF7F00	255	127	0	32767
darkorange 2	 	darkorange 2	#EE7600	238	118	0	30446
darkorange 3	 	darkorange 3	#CD6600	205	102	0	26317
darkorange 4	 	darkorange 4	#8B4500	139	69	0	17803
orange orange	#FF8000	255	128	0	33023
tan 1	 	tan 1	#FFA54F	255	165	79	5219839
tan 2	 	tan 2	#EE9A49	238	154	73	4823790
tan 3 (peru)	 	tan 3 (peru)	#CD853F	205	133	63	4163021
tan 4	 	tan 4	#8B5A2B	139	90	43	2841227
linen linen	#FAF0E6	250	240	230	15134970
peachpuff 1 (peachpuff)	 	peachpuff 1 (peachpuff)	#FFDAB9	255	218	185	12180223
peachpuff 2	 	peachpuff 2	#EECBAD	238	203	173	11389934
peachpuff 3	 	peachpuff 3	#CDAF95	205	175	149	9809869
peachpuff 4	 	peachpuff 4	#8B7765	139	119	101	6649739
seashell 1 (seashell)	 	seashell 1 (seashell)	#FFF5EE	255	245	238	15660543
seashell 2	 	seashell 2	#EEE5DE	238	229	222	14607854
seashell 3	 	seashell 3	#CDC5BF	205	197	191	12568013
seashell 4	 	seashell 4	#8B8682	139	134	130	8554123
sandybrown sandybrown	#F4A460	244	164	96	6333684
rawsienna rawsienna	#C76114	199	97	20	1335751
chocolate chocolate	#D2691E	210	105	30	1993170
chocolate 1	 	chocolate 1	#FF7F24	255	127	36	2392063
chocolate 2	 	chocolate 2	#EE7621	238	118	33	2193134
chocolate 3	 	chocolate 3	#CD661D	205	102	29	1926861
chocolate 4 (saddlebrown)	 	chocolate 4 (saddlebrown)	#8B4513	139	69	19	1262987
ivoryblack ivoryblack	#292421	41	36	33	2171945
flesh flesh	#FF7D40	255	125	64	4226559
cadmiumorange cadmiumorange	#FF6103	255	97	3	221695
burntsienna burntsienna	#8A360F	138	54	15	997002
sienna sienna	#A0522D	160	82	45	2970272
sienna 1	 	sienna 1	#FF8247	255	130	71	4686591
sienna 2	 	sienna 2	#EE7942	238	121	66	4356590
sienna 3	 	sienna 3	#CD6839	205	104	57	3762381
sienna 4	 	sienna 4	#8B4726	139	71	38	2508683
lightsalmon 1 (lightsalmon)	 	lightsalmon 1 (lightsalmon)	#FFA07A	255	160	122	8036607
lightsalmon 2	 	lightsalmon 2	#EE9572	238	149	114	7509486
lightsalmon 3	 	lightsalmon 3	#CD8162	205	129	98	6455757
lightsalmon 4	 	lightsalmon 4	#8B5742	139	87	66	4347787
coral coral	#FF7F50	255	127	80	5275647
orangered 1 (orangered)	 	orangered 1 (orangered)	#FF4500	255	69	0	17919
orangered 2	 	orangered 2	#EE4000	238	64	0	16622
orangered 3	 	orangered 3	#CD3700	205	55	0	14285
orangered 4	 	orangered 4	#8B2500	139	37	0	9611
sepia sepia	#5E2612	94	38	18	1189470
darksalmon darksalmon	#E9967A	233	150	122	8034025
salmon 1	 	salmon 1	#FF8C69	255	140	105	6917375
salmon 2	 	salmon 2	#EE8262	238	130	98	6456046
salmon 3	 	salmon 3	#CD7054	205	112	84	5533901
salmon 4	 	salmon 4	#8B4C39	139	76	57	3755147
coral 1	 	coral 1	#FF7256	255	114	86	5665535
coral 2	 	coral 2	#EE6A50	238	106	80	5270254
coral 3	 	coral 3	#CD5B45	205	91	69	4545485
coral 4	 	coral 4	#8B3E2F	139	62	47	3096203
burntumber burntumber	#8A3324	138	51	36	2372490
tomato 1 (tomato)	 	tomato 1 (tomato)	#FF6347	255	99	71	4678655
tomato 2	 	tomato 2	#EE5C42	238	92	66	4349166
tomato 3	 	tomato 3	#CD4F39	205	79	57	3755981
tomato 4	 	tomato 4	#8B3626	139	54	38	2504331
salmon salmon	#FA8072	250	128	114	7504122
mistyrose 1 (mistyrose)	 	mistyrose 1 (mistyrose)	#FFE4E1	255	228	225	14804223
mistyrose 2	 	mistyrose 2	#EED5D2	238	213	210	13817326
mistyrose 3	 	mistyrose 3	#CDB7B5	205	183	181	11909069
mistyrose 4	 	mistyrose 4	#8B7D7B	139	125	123	8093067
snow 1 (snow)	 	snow 1 (snow)	#FFFAFA	255	250	250	16448255
snow 2	 	snow 2	#EEE9E9	238	233	233	15329774
snow 3	 	snow 3	#CDC9C9	205	201	201	13224397
snow 4	 	snow 4	#8B8989	139	137	137	9013643
rosybrown rosybrown	#BC8F8F	188	143	143	9408444
rosybrown 1	 	rosybrown 1	#FFC1C1	255	193	193	12698111
rosybrown 2	 	rosybrown 2	#EEB4B4	238	180	180	11842798
rosybrown 3	 	rosybrown 3	#CD9B9B	205	155	155	10197965
rosybrown 4	 	rosybrown 4	#8B6969	139	105	105	6908299
lightcoral lightcoral	#F08080	240	128	128	8421616
indianred indianred	#CD5C5C	205	92	92	6053069
indianred 1	 	indianred 1	#FF6A6A	255	106	106	6974207
indianred 2	 	indianred 2	#EE6363	238	99	99	6513646
indianred 4	 	indianred 4	#8B3A3A	139	58	58	3816075
indianred 3	 	indianred 3	#CD5555	205	85	85	5592525
brown brown	#A52A2A	165	42	42	2763429
brown 1	 	brown 1	#FF4040	255	64	64	4210943
brown 2	 	brown 2	#EE3B3B	238	59	59	3881966
brown 3	 	brown 3	#CD3333	205	51	51	3355597
brown 4	 	brown 4	#8B2323	139	35	35	2302859
firebrick firebrick	#B22222	178	34	34	2237106
firebrick 1	 	firebrick 1	#FF3030	255	48	48	3158271
firebrick 2	 	firebrick 2	#EE2C2C	238	44	44	2895086
firebrick 3	 	firebrick 3	#CD2626	205	38	38	2500301
firebrick 4	 	firebrick 4	#8B1A1A	139	26	26	1710731
red 1 (red*)	 	red 1 (red*)	#FF0000	255	0	0	255
red 2	 	red 2	#EE0000	238	0	0	238
red 3	 	red 3	#CD0000	205	0	0	205
red 4 (darkred)	 	red 4 (darkred)	#8B0000	139	0	0	139
maroon* maroon*	#800000	128	0	0	128
sgi beet sgi beet	#8E388E	142	56	142	9320590
sgi slateblue sgi slateblue	#7171C6	113	113	198	13005169
sgi lightblue sgi lightblue	#7D9EC0	125	158	192	12623485
sgi teal sgi teal	#388E8E	56	142	142	9342520
sgi chartreuse sgi chartreuse	#71C671	113	198	113	7456369
sgi olivedrab sgi olivedrab	#8E8E38	142	142	56	3706510
sgi brightgray sgi brightgray	#C5C1AA	197	193	170	11190725
sgi salmon sgi salmon	#C67171	198	113	113	7434694
sgi darkgray sgi darkgray	#555555	85	85	85	5592405
sgi gray 12	 	sgi gray 12	#1E1E1E	30	30	30	1973790
sgi gray 16	 	sgi gray 16	#282828	40	40	40	2631720
sgi gray 32	 	sgi gray 32	#515151	81	81	81	5329233
sgi gray 36	 	sgi gray 36	#5B5B5B	91	91	91	5987163
sgi gray 52	 	sgi gray 52	#848484	132	132	132	8684676
sgi gray 56	 	sgi gray 56	#8E8E8E	142	142	142	9342606
sgi lightgray       sgi lightgray	#AAAAAA	170	170	170	11184810
sgi gray 72	 	sgi gray 72	#B7B7B7	183	183	183	12040119
sgi gray 76	 	sgi gray 76	#C1C1C1	193	193	193	12698049
sgi gray 92	 	sgi gray 92	#EAEAEA	234	234	234	15395562
sgi gray 96	 	sgi gray 96	#F4F4F4	244	244	244	16053492
white* white*	#FFFFFF	255	255	255	16777215
white smoke(gray 96)       white smoke(gray 96)	#F5F5F5	245	245	245	16119285
gainsboro gainsboro	#DCDCDC	220	220	220	14474460
lightgrey lightgrey	#D3D3D3	211	211	211	13882323
silver* silver*	#C0C0C0	192	192	192	12632256
darkgray        darkgray	#A9A9A9	169	169	169	11119017
gray* gray*	#808080	128	128	128	8421504
dimgray(gray 42)       dimgray(gray 42)	#696969	105	105	105	6908265
black* black*	#000000	0	0	0	0
gray 99	 	gray 99	#FCFCFC	252	252	252	16579836
gray 98	 	gray 98	#FAFAFA	250	250	250	16448250
gray 97	 	gray 97	#F7F7F7	247	247	247	16250871
white smoke(gray 96)       white smoke(gray 96)	#F5F5F5	245	245	245	16119285
gray 95	 	gray 95	#F2F2F2	242	242	242	15921906
gray 94	 	gray 94	#F0F0F0	240	240	240	15790320
gray 93	 	gray 93	#EDEDED	237	237	237	15592941
gray 92	 	gray 92	#EBEBEB	235	235	235	15461355
gray 91	 	gray 91	#E8E8E8	232	232	232	15263976
gray 90	 	gray 90	#E5E5E5	229	229	229	15066597
gray 89	 	gray 89	#E3E3E3	227	227	227	14935011
gray 88	 	gray 88	#E0E0E0	224	224	224	14737632
gray 87	 	gray 87	#DEDEDE	222	222	222	14606046
gray 86	 	gray 86	#DBDBDB	219	219	219	14408667
gray 85	 	gray 85	#D9D9D9	217	217	217	14277081
gray 84	 	gray 84	#D6D6D6	214	214	214	14079702
gray 83	 	gray 83	#D4D4D4	212	212	212	13948116
gray 82	 	gray 82	#D1D1D1	209	209	209	13750737
gray 81	 	gray 81	#CFCFCF	207	207	207	13619151
gray 80	 	gray 80	#CCCCCC	204	204	204	13421772
gray 79	 	gray 79	#C9C9C9	201	201	201	13224393
gray 78	 	gray 78	#C7C7C7	199	199	199	13092807
gray 77	 	gray 77	#C4C4C4	196	196	196	12895428
gray 76	 	gray 76	#C2C2C2	194	194	194	12763842
gray 75	 	gray 75	#BFBFBF	191	191	191	12566463
gray 74	 	gray 74	#BDBDBD	189	189	189	12434877
gray 73	 	gray 73	#BABABA	186	186	186	12237498
gray 72	 	gray 72	#B8B8B8	184	184	184	12105912
gray 71	 	gray 71	#B5B5B5	181	181	181	11908533
gray 70	 	gray 70	#B3B3B3	179	179	179	11776947
gray 69	 	gray 69	#B0B0B0	176	176	176	11579568
gray 68	 	gray 68	#ADADAD	173	173	173	11382189
gray 67	 	gray 67	#ABABAB	171	171	171	11250603
gray 66	 	gray 66	#A8A8A8	168	168	168	11053224
gray 65	 	gray 65	#A6A6A6	166	166	166	10921638
gray 64	 	gray 64	#A3A3A3	163	163	163	10724259
gray 63	 	gray 63	#A1A1A1	161	161	161	10592673
gray 62	 	gray 62	#9E9E9E	158	158	158	10395294
gray 61	 	gray 61	#9C9C9C	156	156	156	10263708
gray 60	 	gray 60	#999999	153	153	153	10066329
gray 59	 	gray 59	#969696	150	150	150	9868950
gray 58	 	gray 58	#949494	148	148	148	9737364
gray 57	 	gray 57	#919191	145	145	145	9539985
gray 56	 	gray 56	#8F8F8F	143	143	143	9408399
gray 55	 	gray 55	#8C8C8C	140	140	140	9211020
gray 54	 	gray 54	#8A8A8A	138	138	138	9079434
gray 53	 	gray 53	#878787	135	135	135	8882055
gray 52	 	gray 52	#858585	133	133	133	8750469
gray 51	 	gray 51	#828282	130	130	130	8553090
gray 50	 	gray 50	#7F7F7F	127	127	127	8355711
gray 49	 	gray 49	#7D7D7D	125	125	125	8224125
gray 48	 	gray 48	#7A7A7A	122	122	122	8026746
gray 47	 	gray 47	#787878	120	120	120	7895160
gray 46	 	gray 46	#757575	117	117	117	7697781
gray 45	 	gray 45	#737373	115	115	115	7566195
gray 44	 	gray 44	#707070	112	112	112	7368816
gray 43	 	gray 43	#6E6E6E	110	110	110	7237230
gray 42	 	gray 42	#6B6B6B	107	107	107	7039851
dimgray(gray 42)       dimgray(gray 42)	#696969	105	105	105	6908265
gray 40	 	gray 40	#666666	102	102	102	6710886
gray 39	 	gray 39	#636363	99	99	99	6513507
gray 38	 	gray 38	#616161	97	97	97	6381921
gray 37	 	gray 37	#5E5E5E	94	94	94	6184542
gray 36	 	gray 36	#5C5C5C	92	92	92	6052956
gray 35	 	gray 35	#595959	89	89	89	5855577
gray 34	 	gray 34	#575757	87	87	87	5723991
gray 33	 	gray 33	#545454	84	84	84	5526612
gray 32	 	gray 32	#525252	82	82	82	5395026
gray 31	 	gray 31	#4F4F4F	79	79	79	5197647
gray 30	 	gray 30	#4D4D4D	77	77	77	5066061
gray 29	 	gray 29	#4A4A4A	74	74	74	4868682
gray 28	 	gray 28	#474747	71	71	71	4671303
gray 27	 	gray 27	#454545	69	69	69	4539717
gray 26	 	gray 26	#424242	66	66	66	4342338
gray 25	 	gray 25	#404040	64	64	64	4210752
gray 24	 	gray 24	#3D3D3D	61	61	61	4013373
gray 23	 	gray 23	#3B3B3B	59	59	59	3881787
gray 22	 	gray 22	#383838	56	56	56	3684408
gray 21	 	gray 21	#363636	54	54	54	3552822
gray 20	 	gray 20	#333333	51	51	51	3355443
gray 19	 	gray 19	#303030	48	48	48	3158064
gray 18	 	gray 18	#2E2E2E	46	46	46	3026478
gray 17	 	gray 17	#2B2B2B	43	43	43	2829099
gray 16	 	gray 16	#292929	41	41	41	2697513
gray 15	 	gray 15	#262626	38	38	38	2500134
gray 14	 	gray 14	#242424	36	36	36	2368548
gray 13	 	gray 13	#212121	33	33	33	2171169
gray 12	 	gray 12	#1F1F1F	31	31	31	2039583
gray 11	 	gray 11	#1C1C1C	28	28	28	1842204
gray 10	 	gray 10	#1A1A1A	26	26	26	1710618
gray 9	 	gray 9	#171717	23	23	23	1513239
gray 8	 	gray 8	#141414	20	20	20	1315860
gray 7	 	gray 7	#121212	18	18	18	1184274
gray 6	 	gray 6	#0F0F0F	15	15	15	986895
gray 5	 	gray 5	#0D0D0D	13	13	13	855309
gray 4	 	gray 4	#0A0A0A	10	10	10	657930
gray 3	 	gray 3	#080808	8	8	8	526344
gray 2	 	gray 2	#050505	5	5	5	328965
gray 1	 	gray 1	#030303	3	3	3	197379
*/