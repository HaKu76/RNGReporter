﻿/*
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

using System.Globalization;
using System.Windows.Forms;

namespace RNGReporter.Objects
{
    internal static class FormsFunctions
    {
        public static bool ParseInputH(TextBoxBase control, out uint value)
        {
            if (!uint.TryParse(control.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out value))
            {
                control.Focus();
                control.SelectAll();
                return false;
            }
            return true;
        }

        public static bool ParseInputH(TextBoxBase control, out ulong value)
        {
            if (!ulong.TryParse(control.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out value))
            {
                control.Focus();
                control.SelectAll();
                return false;
            }
            return true;
        }

        public static bool ParseInputD(TextBoxBase control, out ushort value)
        {
            if (!ushort.TryParse(control.Text, out value))
            {
                control.Focus();
                control.SelectAll();
                return false;
            }
            return true;
        }

        public static bool ParseInputD(TextBoxBase control, out uint value)
        {
            if (!uint.TryParse(control.Text, out value))
            {
                control.Focus();
                control.SelectAll();
                return false;
            }
            return true;
        }

        public static bool ParseInputD(TextBoxBase control, out ulong value)
        {
            if (!ulong.TryParse(control.Text, out value))
            {
                control.Focus();
                control.SelectAll();
                return false;
            }
            return true;
        }

        public static void FocusControl(object sender, MouseEventArgs e)
        {
            ((Control)sender).Focus();
        }
    }
}