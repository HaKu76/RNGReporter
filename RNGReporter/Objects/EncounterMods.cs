/*
 * This file is part of RNG Reporter
 * Copyright (C) 2012 by Bill Young, Mike Suleski, and Andrew Ringer
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */


using RNGReporter.Properties;

namespace RNGReporter.Objects
{
    public enum EncounterType
    {
        Wild,
        WildSurfing,
        WildOldRod,
        WildGoodRod,
        WildSuperRod,
        WildWaterSpot,
        WildSwarm,
        WildShakerGrass,
        WildCaveSpot,
        Stationary,
        Roamer,
        Gift,
        Entralink,
        LarvestaEgg,
        AllEncounterShiny,
        BugCatchingContest,
        SafariZone,
        Headbutt,
        Manaphy,
        HiddenGrotto
    };

    public enum EncounterMod
    {
        None,
        Search,
        Synchronize,
        Compoundeyes,
        SuctionCups,
        CuteCharm,
        Everstone,
        CuteCharm50M,
        CuteCharm75M,
        CuteCharm25M,
        CuteCharm875M,
        CuteCharm50F,
        CuteCharm75F,
        CuteCharm25F,
        CuteCharm125F,
        CuteCharmFemale
    };

    internal class EncounterTypeCalc
    {
        public static string[] encounterStringENG =
            {
                "None",
                "Synchronize",
                "Cute Charm",
                "Suction Cups",
                "Compoundeyes",
                "Everstone",
                "Unknown"
            };

        public static string[] encounterStringJPN =
            {
                "何も",
                "シンクロ",
                "メロメロボディ",
                "きゅうばん",
                "ふくがん",
                "かわらずのいし",
                "未知"
            };

        public static string[] encounterStringGER =
            {
                "Keiner",
                "Synchro",
                "Charmebolzen",
                "Saugnapf",
                "Facettenauge",
                "Ewigstein",
                "Unbekannt"
            };

        public static string[] encounterStringSPA =
            {
                "Ninguno",
                "Sincronía",
                "Gran Encanto",
                "Ventosas",
                "Ojocompuesto",
                "Piedraeterna",
                "Desconocido"
            };

        public static string[] encounterStringFRA =
            {
                "Aucun",
                "Synchro",
                "Joli Sourire",
                "Ventouse",
                "Œil Composé",
                "Pierre Stase",
                "Inconnu"
            };

        public static string[] encounterStringITA =
            {
                "Nessuno",
                "Sincronismo",
                "Incantevole",
                "Ventose",
                "Insettocchi",
                "Pietrastante",
                "Sconosciuto"
            };

        public static string[] encounterStringKOR =
            {
                "없음",
                "싱크로",
                "헤롱헤롱 바디",
                "흡반",
                "복안",
                "변함없는돌",
                "알 수없는"
            };

        public static string[] encounterStringCHS =
    {
                "无",
                "同步",
                "迷人之躯",
                "吸盘",
                "复眼",
                "不变之石",
                "未知"
            };

        public static EncounterType EncounterString(string encounterType)
        {
            switch (encounterType)
            {
                case "野生宝可梦":
                    return EncounterType.Wild;
                case "野生宝可梦（冲浪）":
                    return EncounterType.WildSurfing;
                case "野生宝可梦（钓鱼）":
                    return EncounterType.WildSuperRod;
                case "野生宝可梦（破旧钓竿）":
                    return EncounterType.WildOldRod;
                case "野生宝可梦（好钓竿）":
                    return EncounterType.WildGoodRod;
                case "野生宝可梦（厉害钓竿）":
                    return EncounterType.WildSuperRod;
                case "野生宝可梦（虫之预感）":
                    return EncounterType.WildSwarm;
                case "野生宝可梦（摇动草丛）":
                    return EncounterType.WildShakerGrass;
                case "野生宝可梦（水纹水面）":
                    return EncounterType.WildWaterSpot;
                case "野生宝可梦（卷尘地面）":
                    return EncounterType.WildCaveSpot;
                case "定点宝可梦":
                    return EncounterType.Stationary;
                case "游走宝可梦":
                    return EncounterType.Roamer;
                case "礼物宝可梦":
                    return EncounterType.Gift;
                case "连入之森宝可梦":
                    return EncounterType.Entralink;
                case "燃烧虫的蛋":
                    return EncounterType.LarvestaEgg;
                case "隐藏洞穴":
                    return EncounterType.HiddenGrotto;
                case "所有遭遇异色":
                    return EncounterType.AllEncounterShiny;
                case "捕虫大赛":
                    return EncounterType.BugCatchingContest;
                case "狩猎地带":
                    return EncounterType.SafariZone;
                case "玛纳霏的蛋":
                    return EncounterType.Manaphy;
                case "头锤树":
                    return EncounterType.Headbutt;
                default:
                    return EncounterType.Wild;
            }
        }

        public static string StringMod(EncounterMod encounterMod)
        {
            switch (encounterMod)
            {
                case EncounterMod.Synchronize:
                    return EncounterString(1);
                case EncounterMod.CuteCharm:
                    return EncounterString(2);
                case EncounterMod.SuctionCups:
                    return EncounterString(3);
                case EncounterMod.Compoundeyes:
                    return EncounterString(4);
                case EncounterMod.CuteCharm50M:
                    return EncounterString(2) + " (50% M)";
                case EncounterMod.CuteCharm75M:
                    return EncounterString(2) + " (75% M)";
                case EncounterMod.CuteCharm25M:
                    return EncounterString(2) + " (25% M)";
                case EncounterMod.CuteCharm875M:
                    return EncounterString(2) + " (87.5% M)";
                case EncounterMod.CuteCharm50F:
                    return EncounterString(2) + " (50% F)";
                case EncounterMod.CuteCharm75F:
                    return EncounterString(2) + " (75% F)";
                case EncounterMod.CuteCharm25F:
                    return EncounterString(2) + " (25% F)";
                case EncounterMod.CuteCharm125F:
                    return EncounterString(2) + " (12.5% F)";
                case EncounterMod.CuteCharmFemale:
                    return EncounterString(2) + " (Female)";
                case EncounterMod.Everstone:
                    return EncounterString(5);
                case EncounterMod.None:
                    return EncounterString(0);
                default:
                    return "Unknown";
            }
        }

        public static string EncounterString(int index)
        {
            switch ((Language)Settings.Default.Language)
            {
                case (Language.Japanese):
                    return encounterStringJPN[index];
                case (Language.German):
                    return encounterStringGER[index];
                case (Language.French):
                    return encounterStringFRA[index];
                case (Language.Spanish):
                    return encounterStringSPA[index];
                case (Language.Italian):
                    return encounterStringITA[index];
                case (Language.Korean):
                    return encounterStringKOR[index];
                case (Language.SimplifiedChinese):
                    return encounterStringCHS[index];
                default:
                    return encounterStringENG[index];
            }
        }
    }
}