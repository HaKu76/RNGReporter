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


using System.Collections.Generic;

namespace RNGReporter.Objects
{
    internal class GenderGenderRatio
    {
        public GenderGenderRatio(string name, string shortName, uint lowValue, uint highValue)
        {
            Name = name;
            ShortName = shortName;
            LowValue = lowValue;
            HighValue = highValue;
        }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public uint LowValue { get; set; }

        public uint HighValue { get; set; }

        public bool Matches(uint genderNumber)
        {
            bool matches = genderNumber >= LowValue && genderNumber <= HighValue;

            return matches;
        }

        // This is the gender ratio collection for Chain to SID
        // Not going to mess with old code, so we'll leave it as is
        public static List<GenderGenderRatio> GenderGenderRatioCollection()
        {
            var genderGenderRatioCollection =
                new List<GenderGenderRatio>
                    {
                        new GenderGenderRatio("无性别", "无性别", 0, 255),
                        new GenderGenderRatio("♂(♂1：♀1)", "♂", 127, 255),
                        new GenderGenderRatio("♀(♂1：♀1)", "♀", 0, 126),
                        new GenderGenderRatio("♂(♂1：♀3)", "♂", 191, 255),
                        new GenderGenderRatio("♀(♂1：♀3)", "♀", 0, 190),
                        new GenderGenderRatio("♂(♂3：♀1)", "♂", 64, 255),
                        new GenderGenderRatio("♀(♂3：♀1)", "♀", 0, 63),
                        new GenderGenderRatio("♂(♂7：♀1)", "♂", 31, 255),
                        new GenderGenderRatio("♀(♂7：♀1)", "♀", 0, 30),
                        new GenderGenderRatio("♂(只有♂)", "♂", 0, 255),
                        new GenderGenderRatio("♀(只有♀)", "♀", 0, 255)
                    };

            return genderGenderRatioCollection;
        }

        // This is the gender ratio collection we'll use for frame filters
        public static List<GenderGenderRatio> GenderRatioCollection()
        {
            var genderRatioCollection =
                new List<GenderGenderRatio>
                    {
                        new GenderGenderRatio("无性别", "无性别", 0, 255),
                        new GenderGenderRatio("♂(♂1：♀1)", "♂", 127, 255),
                        new GenderGenderRatio("♀(♂1：♀1)", "♀", 0, 126),
                        new GenderGenderRatio("♂(♂1：♀3)", "♂", 191, 255),
                        new GenderGenderRatio("♀(♂1：♀3)", "♀", 0, 190),
                        new GenderGenderRatio("♂(♂3：♀1)", "♂", 63, 255),
                        new GenderGenderRatio("♀(♂3：♀1)", "♀", 0, 62),
                        new GenderGenderRatio("♂(♂7：♀1)", "♂", 31, 255),
                        new GenderGenderRatio("♀(♂7：♀1)", "♀", 0, 30),
                        new GenderGenderRatio("♂(只有♂)", "♂", 0, 0),
                        new GenderGenderRatio("♀(只有♀)", "♀", 255, 255)
                    };

            return genderRatioCollection;
        }
    }

    internal enum GenderCriteria
    {
        DontCareGenderless,
        Male,
        Female
    }

    internal class GenderFilter
    {
        public GenderFilter(string name, uint genderValue, GenderCriteria genderCriteria)
        {
            Name = name;
            GenderValue = genderValue;
            GenderCriteria = genderCriteria;
        }

        public GenderFilter()
        {
            // blank constructor for the NoFilter class
        }

        public string Name { get; protected set; }

        public uint GenderValue { get; protected set; }

        public GenderCriteria GenderCriteria { get; protected set; }

        public override string ToString()
        {
            return Name;
        }

        public bool Filter(uint genderValue)
        {
            if (GenderCriteria == GenderCriteria.Male)
            {
                return genderValue >= GenderValue;
            }

            if (GenderCriteria == GenderCriteria.Female)
            {
                return genderValue < GenderValue;
            }

            return true;
        }

        public bool Filter(EncounterMod encounterMod)
        {
            switch (encounterMod)
            {
                case EncounterMod.CuteCharmFemale:
                    return GenderCriteria != GenderCriteria.Male && GenderValue != 0 && GenderValue != 254;
                case EncounterMod.CuteCharm875M:
                    return GenderValue == 255 || GenderValue == 31;
                case EncounterMod.CuteCharm50M:
                    return GenderValue == 255 || GenderValue == 127;
                case EncounterMod.CuteCharm75M:
                    return GenderValue == 255 || GenderValue == 63;
                case EncounterMod.CuteCharm25M:
                    return GenderValue == 255 || GenderValue == 191;
                case EncounterMod.CuteCharm125F:
                    return GenderValue == 255 || GenderValue == 31;
                case EncounterMod.CuteCharm50F:
                    return GenderValue == 255 || GenderValue == 127;
                case EncounterMod.CuteCharm75F:
                    return GenderValue == 255 || GenderValue == 191;
                case EncounterMod.CuteCharm25F:
                    return GenderValue == 255 || GenderValue == 63;
                default:
                    return true;
            }
        }

        public static List<GenderFilter> GenderFilterCollection()
        {
            var GenderFilterCollection =
                new List<GenderFilter>
                    {
                        new NoGenderFilter("不考虑/无性别/固定性别"),
                        new GenderFilter("♂(♂1：♀1)", 127, GenderCriteria.Male),
                        new GenderFilter("♀(♂1：♀1)", 127, GenderCriteria.Female),
                        new GenderFilter("♂(♂1：♀3)", 191, GenderCriteria.Male),
                        new GenderFilter("♀(♂1：♀3)", 191, GenderCriteria.Female),
                        new GenderFilter("♂(♂3：♀1)", 63, GenderCriteria.Male),
                        new GenderFilter("♀(♂3：♀1)", 63, GenderCriteria.Female),
                        new GenderFilter("♂(♂7：♀1)", 31, GenderCriteria.Male),
                        new GenderFilter("♀(♂7：♀1)", 31, GenderCriteria.Female)
                    };

            return GenderFilterCollection;
        }

        // This is the collection we use for the main window
        // Entralink PIDs need to know gender values
        // So we added Genderless and 100% male\female entries
        public static List<GenderFilter> GenderFilterCollectionMain()
        {
            var GenderFilterCollection =
                new List<GenderFilter>
                    {
                        new GenderFilter("不考虑/无性别", 255, GenderCriteria.DontCareGenderless),
                        new GenderFilter("♂(♂1：♀1)", 127, GenderCriteria.Male),
                        new GenderFilter("♀(♂1：♀1)", 127, GenderCriteria.Female),
                        new GenderFilter("♂(♂1：♀3)", 191, GenderCriteria.Male),
                        new GenderFilter("♀(♂1：♀3)", 191, GenderCriteria.Female),
                        new GenderFilter("♂(♂3：♀1)", 63, GenderCriteria.Male),
                        new GenderFilter("♀(♂3：♀1)", 63, GenderCriteria.Female),
                        new GenderFilter("♂(♂7：♀1)", 31, GenderCriteria.Male),
                        new GenderFilter("♀(♂7：♀1)", 31, GenderCriteria.Female),
                        new GenderFilter("♂(只有♂)", 0, GenderCriteria.DontCareGenderless),
                        new GenderFilter("♀(只有♀)", 254, GenderCriteria.DontCareGenderless)
                    };

            return GenderFilterCollection;
        }
    }

    internal class NoGenderFilter : GenderFilter
    {
        public NoGenderFilter()
        {
        }

        public NoGenderFilter(string name)
        {
            Name = name;
        }

        public new bool Filter(uint genderValue)
        {
            return true;
        }
    }
}