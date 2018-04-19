// Color.cs
//
// Authors:
//   Sebastian Faltoni
//
// Copyright (C) 2006 DotNetNTDLS (http://www.dotnetNTDLS.net)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.Text;

namespace NTDLS.Cairo
{
    public class Colors
    {

        static public Color Transparent
        {
            get
            {
                return Color.FromArgbNamed(0, 255, 255, 255, "Transparent", KnownColor.Transparent);
            }
        }

        static public Color AliceBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 240, 248, 255, "AliceBlue", KnownColor.AliceBlue);
            }
        }

        static public Color AntiqueWhite
        {
            get
            {
                return Color.FromArgbNamed(255, 250, 235, 215, "AntiqueWhite", KnownColor.AntiqueWhite);
            }
        }

        static public Color Aqua
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 255, 255, "Aqua", KnownColor.Aqua);
            }
        }

        static public Color Aquamarine
        {
            get
            {
                return Color.FromArgbNamed(255, 127, 255, 212, "Aquamarine", KnownColor.Aquamarine);
            }
        }

        static public Color Azure
        {
            get
            {
                return Color.FromArgbNamed(255, 240, 255, 255, "Azure", KnownColor.Azure);
            }
        }

        static public Color Beige
        {
            get
            {
                return Color.FromArgbNamed(255, 245, 245, 220, "Beige", KnownColor.Beige);
            }
        }

        static public Color Bisque
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 228, 196, "Bisque", KnownColor.Bisque);
            }
        }

        static public Color Black
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 0, 0, "Black", KnownColor.Black);
            }
        }

        static public Color BlanchedAlmond
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 235, 205, "BlanchedAlmond", KnownColor.BlanchedAlmond);
            }
        }

        static public Color Blue
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 0, 255, "Blue", KnownColor.Blue);
            }
        }

        static public Color BlueViolet
        {
            get
            {
                return Color.FromArgbNamed(255, 138, 43, 226, "BlueViolet", KnownColor.BlueViolet);
            }
        }

        static public Color Brown
        {
            get
            {
                return Color.FromArgbNamed(255, 165, 42, 42, "Brown", KnownColor.Brown);
            }
        }

        static public Color BurlyWood
        {
            get
            {
                return Color.FromArgbNamed(255, 222, 184, 135, "BurlyWood", KnownColor.BurlyWood);
            }
        }

        static public Color CadetBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 95, 158, 160, "CadetBlue", KnownColor.CadetBlue);
            }
        }

        static public Color Chartreuse
        {
            get
            {
                return Color.FromArgbNamed(255, 127, 255, 0, "Chartreuse", KnownColor.Chartreuse);
            }
        }

        static public Color Chocolate
        {
            get
            {
                return Color.FromArgbNamed(255, 210, 105, 30, "Chocolate", KnownColor.Chocolate);
            }
        }

        static public Color Coral
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 127, 80, "Coral", KnownColor.Coral);
            }
        }

        static public Color CornflowerBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 100, 149, 237, "CornflowerBlue", KnownColor.CornflowerBlue);
            }
        }

        static public Color Cornsilk
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 248, 220, "Cornsilk", KnownColor.Cornsilk);
            }
        }

        static public Color Crimson
        {
            get
            {
                return Color.FromArgbNamed(255, 220, 20, 60, "Crimson", KnownColor.Crimson);
            }
        }

        static public Color Cyan
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 255, 255, "Cyan", KnownColor.Cyan);
            }
        }

        static public Color DarkBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 0, 139, "DarkBlue", KnownColor.DarkBlue);
            }
        }

        static public Color DarkCyan
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 139, 139, "DarkCyan", KnownColor.DarkCyan);
            }
        }

        static public Color DarkGoldenrod
        {
            get
            {
                return Color.FromArgbNamed(255, 184, 134, 11, "DarkGoldenrod", KnownColor.DarkGoldenrod);
            }
        }

        static public Color DarkGray
        {
            get
            {
                return Color.FromArgbNamed(255, 169, 169, 169, "DarkGray", KnownColor.DarkGray);
            }
        }

        static public Color DarkGreen
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 100, 0, "DarkGreen", KnownColor.DarkGreen);
            }
        }

        static public Color DarkKhaki
        {
            get
            {
                return Color.FromArgbNamed(255, 189, 183, 107, "DarkKhaki", KnownColor.DarkKhaki);
            }
        }

        static public Color DarkMagenta
        {
            get
            {
                return Color.FromArgbNamed(255, 139, 0, 139, "DarkMagenta", KnownColor.DarkMagenta);
            }
        }

        static public Color DarkOliveGreen
        {
            get
            {
                return Color.FromArgbNamed(255, 85, 107, 47, "DarkOliveGreen", KnownColor.DarkOliveGreen);
            }
        }

        static public Color DarkOrange
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 140, 0, "DarkOrange", KnownColor.DarkOrange);
            }
        }

        static public Color DarkOrchid
        {
            get
            {
                return Color.FromArgbNamed(255, 153, 50, 204, "DarkOrchid", KnownColor.DarkOrchid);
            }
        }

        static public Color DarkRed
        {
            get
            {
                return Color.FromArgbNamed(255, 139, 0, 0, "DarkRed", KnownColor.DarkRed);
            }
        }

        static public Color DarkSalmon
        {
            get
            {
                return Color.FromArgbNamed(255, 233, 150, 122, "DarkSalmon", KnownColor.DarkSalmon);
            }
        }

        static public Color DarkSeaGreen
        {
            get
            {
                return Color.FromArgbNamed(255, 143, 188, 139, "DarkSeaGreen", KnownColor.DarkSeaGreen);
            }
        }

        static public Color DarkSlateBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 72, 61, 139, "DarkSlateBlue", KnownColor.DarkSlateBlue);
            }
        }

        static public Color DarkSlateGray
        {
            get
            {
                return Color.FromArgbNamed(255, 47, 79, 79, "DarkSlateGray", KnownColor.DarkSlateGray);
            }
        }

        static public Color DarkTurquoise
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 206, 209, "DarkTurquoise", KnownColor.DarkTurquoise);
            }
        }

        static public Color DarkViolet
        {
            get
            {
                return Color.FromArgbNamed(255, 148, 0, 211, "DarkViolet", KnownColor.DarkViolet);
            }
        }

        static public Color DeepPink
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 20, 147, "DeepPink", KnownColor.DeepPink);
            }
        }

        static public Color DeepSkyBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 191, 255, "DeepSkyBlue", KnownColor.DeepSkyBlue);
            }
        }

        static public Color DimGray
        {
            get
            {
                return Color.FromArgbNamed(255, 105, 105, 105, "DimGray", KnownColor.DimGray);
            }
        }

        static public Color DodgerBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 30, 144, 255, "DodgerBlue", KnownColor.DodgerBlue);
            }
        }

        static public Color Firebrick
        {
            get
            {
                return Color.FromArgbNamed(255, 178, 34, 34, "Firebrick", KnownColor.Firebrick);
            }
        }

        static public Color FloralWhite
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 250, 240, "FloralWhite", KnownColor.FloralWhite);
            }
        }

        static public Color ForestGreen
        {
            get
            {
                return Color.FromArgbNamed(255, 34, 139, 34, "ForestGreen", KnownColor.ForestGreen);
            }
        }

        static public Color Fuchsia
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 0, 255, "Fuchsia", KnownColor.Fuchsia);
            }
        }

        static public Color Gainsboro
        {
            get
            {
                return Color.FromArgbNamed(255, 220, 220, 220, "Gainsboro", KnownColor.Gainsboro);
            }
        }

        static public Color GhostWhite
        {
            get
            {
                return Color.FromArgbNamed(255, 248, 248, 255, "GhostWhite", KnownColor.GhostWhite);
            }
        }

        static public Color Gold
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 215, 0, "Gold", KnownColor.Gold);
            }
        }

        static public Color Goldenrod
        {
            get
            {
                return Color.FromArgbNamed(255, 218, 165, 32, "Goldenrod", KnownColor.Goldenrod);
            }
        }

        static public Color Gray
        {
            get
            {
                return Color.FromArgbNamed(255, 128, 128, 128, "Gray", KnownColor.Gray);
            }
        }

        static public Color Green
        {
            get
            {
                // LAMESPEC: MS uses A=255, R=0, G=128, B=0 for Green Color,
                // which is seems to be wrong. G must be 255.
                return Color.FromArgbNamed(255, 0, 128, 0, "Green", KnownColor.Green);
            }
        }

        static public Color GreenYellow
        {
            get
            {
                return Color.FromArgbNamed(255, 173, 255, 47, "GreenYellow", KnownColor.GreenYellow);
            }
        }

        static public Color Honeydew
        {
            get
            {
                return Color.FromArgbNamed(255, 240, 255, 240, "Honeydew", KnownColor.Honeydew);
            }
        }

        static public Color HotPink
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 105, 180, "HotPink", KnownColor.HotPink);
            }
        }

        static public Color IndianRed
        {
            get
            {
                return Color.FromArgbNamed(255, 205, 92, 92, "IndianRed", KnownColor.IndianRed);
            }
        }

        static public Color Indigo
        {
            get
            {
                return Color.FromArgbNamed(255, 75, 0, 130, "Indigo", KnownColor.Indigo);
            }
        }

        static public Color Ivory
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 255, 240, "Ivory", KnownColor.Ivory);
            }
        }

        static public Color Khaki
        {
            get
            {
                return Color.FromArgbNamed(255, 240, 230, 140, "Khaki", KnownColor.Khaki);
            }
        }

        static public Color Lavender
        {
            get
            {
                return Color.FromArgbNamed(255, 230, 230, 250, "Lavender", KnownColor.Lavender);
            }
        }

        static public Color LavenderBlush
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 240, 245, "LavenderBlush", KnownColor.LavenderBlush);
            }
        }

        static public Color LawnGreen
        {
            get
            {
                return Color.FromArgbNamed(255, 124, 252, 0, "LawnGreen", KnownColor.LawnGreen);
            }
        }

        static public Color LemonChiffon
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 250, 205, "LemonChiffon", KnownColor.LemonChiffon);
            }
        }

        static public Color LightBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 173, 216, 230, "LightBlue", KnownColor.LightBlue);
            }
        }

        static public Color LightCoral
        {
            get
            {
                return Color.FromArgbNamed(255, 240, 128, 128, "LightCoral", KnownColor.LightCoral);
            }
        }

        static public Color LightCyan
        {
            get
            {
                return Color.FromArgbNamed(255, 224, 255, 255, "LightCyan", KnownColor.LightCyan);
            }
        }

        static public Color LightGoldenrodYellow
        {
            get
            {
                return Color.FromArgbNamed(255, 250, 250, 210, "LightGoldenrodYellow", KnownColor.LightGoldenrodYellow);
            }
        }

        static public Color LightGreen
        {
            get
            {
                return Color.FromArgbNamed(255, 144, 238, 144, "LightGreen", KnownColor.LightGreen);
            }
        }

        static public Color LightGray
        {
            get
            {
                return Color.FromArgbNamed(255, 211, 211, 211, "LightGray", KnownColor.LightGray);
            }
        }

        static public Color LightPink
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 182, 193, "LightPink", KnownColor.LightPink);
            }
        }

        static public Color LightSalmon
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 160, 122, "LightSalmon", KnownColor.LightSalmon);
            }
        }

        static public Color LightSeaGreen
        {
            get
            {
                return Color.FromArgbNamed(255, 32, 178, 170, "LightSeaGreen", KnownColor.LightSeaGreen);
            }
        }

        static public Color LightSkyBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 135, 206, 250, "LightSkyBlue", KnownColor.LightSkyBlue);
            }
        }

        static public Color LightSlateGray
        {
            get
            {
                return Color.FromArgbNamed(255, 119, 136, 153, "LightSlateGray", KnownColor.LightSlateGray);
            }
        }

        static public Color LightSteelBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 176, 196, 222, "LightSteelBlue", KnownColor.LightSteelBlue);
            }
        }

        static public Color LightYellow
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 255, 224, "LightYellow", KnownColor.LightYellow);
            }
        }

        static public Color Lime
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 255, 0, "Lime", KnownColor.Lime);
            }
        }

        static public Color LimeGreen
        {
            get
            {
                return Color.FromArgbNamed(255, 50, 205, 50, "LimeGreen", KnownColor.LimeGreen);
            }
        }

        static public Color Linen
        {
            get
            {
                return Color.FromArgbNamed(255, 250, 240, 230, "Linen", KnownColor.Linen);
            }
        }

        static public Color Magenta
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 0, 255, "Magenta", KnownColor.Magenta);
            }
        }

        static public Color Maroon
        {
            get
            {
                return Color.FromArgbNamed(255, 128, 0, 0, "Maroon", KnownColor.Maroon);
            }
        }

        static public Color MediumAquamarine
        {
            get
            {
                return Color.FromArgbNamed(255, 102, 205, 170, "MediumAquamarine", KnownColor.MediumAquamarine);
            }
        }

        static public Color MediumBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 0, 205, "MediumBlue", KnownColor.MediumBlue);
            }
        }

        static public Color MediumOrchid
        {
            get
            {
                return Color.FromArgbNamed(255, 186, 85, 211, "MediumOrchid", KnownColor.MediumOrchid);
            }
        }

        static public Color MediumPurple
        {
            get
            {
                return Color.FromArgbNamed(255, 147, 112, 219, "MediumPurple", KnownColor.MediumPurple);
            }
        }

        static public Color MediumSeaGreen
        {
            get
            {
                return Color.FromArgbNamed(255, 60, 179, 113, "MediumSeaGreen", KnownColor.MediumSeaGreen);
            }
        }

        static public Color MediumSlateBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 123, 104, 238, "MediumSlateBlue", KnownColor.MediumSlateBlue);
            }
        }

        static public Color MediumSpringGreen
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 250, 154, "MediumSpringGreen", KnownColor.MediumSpringGreen);
            }
        }

        static public Color MediumTurquoise
        {
            get
            {
                return Color.FromArgbNamed(255, 72, 209, 204, "MediumTurquoise", KnownColor.MediumTurquoise);
            }
        }

        static public Color MediumVioletRed
        {
            get
            {
                return Color.FromArgbNamed(255, 199, 21, 133, "MediumVioletRed", KnownColor.MediumVioletRed);
            }
        }

        static public Color MidnightBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 25, 25, 112, "MidnightBlue", KnownColor.MidnightBlue);
            }
        }

        static public Color MintCream
        {
            get
            {
                return Color.FromArgbNamed(255, 245, 255, 250, "MintCream", KnownColor.MintCream);
            }
        }

        static public Color MistyRose
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 228, 225, "MistyRose", KnownColor.MistyRose);
            }
        }

        static public Color Moccasin
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 228, 181, "Moccasin", KnownColor.Moccasin);
            }
        }

        static public Color NavajoWhite
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 222, 173, "NavajoWhite", KnownColor.NavajoWhite);
            }
        }

        static public Color Navy
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 0, 128, "Navy", KnownColor.Navy);
            }
        }

        static public Color OldLace
        {
            get
            {
                return Color.FromArgbNamed(255, 253, 245, 230, "OldLace", KnownColor.OldLace);
            }
        }

        static public Color Olive
        {
            get
            {
                return Color.FromArgbNamed(255, 128, 128, 0, "Olive", KnownColor.Olive);
            }
        }

        static public Color OliveDrab
        {
            get
            {
                return Color.FromArgbNamed(255, 107, 142, 35, "OliveDrab", KnownColor.OliveDrab);
            }
        }

        static public Color Orange
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 165, 0, "Orange", KnownColor.Orange);
            }
        }

        static public Color OrangeRed
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 69, 0, "OrangeRed", KnownColor.OrangeRed);
            }
        }

        static public Color Orchid
        {
            get
            {
                return Color.FromArgbNamed(255, 218, 112, 214, "Orchid", KnownColor.Orchid);
            }
        }

        static public Color PaleGoldenrod
        {
            get
            {
                return Color.FromArgbNamed(255, 238, 232, 170, "PaleGoldenrod", KnownColor.PaleGoldenrod);
            }
        }

        static public Color PaleGreen
        {
            get
            {
                return Color.FromArgbNamed(255, 152, 251, 152, "PaleGreen", KnownColor.PaleGreen);
            }
        }

        static public Color PaleTurquoise
        {
            get
            {
                return Color.FromArgbNamed(255, 175, 238, 238, "PaleTurquoise", KnownColor.PaleTurquoise);
            }
        }

        static public Color PaleVioletRed
        {
            get
            {
                return Color.FromArgbNamed(255, 219, 112, 147, "PaleVioletRed", KnownColor.PaleVioletRed);
            }
        }

        static public Color PapayaWhip
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 239, 213, "PapayaWhip", KnownColor.PapayaWhip);
            }
        }

        static public Color PeachPuff
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 218, 185, "PeachPuff", KnownColor.PeachPuff);
            }
        }

        static public Color Peru
        {
            get
            {
                return Color.FromArgbNamed(255, 205, 133, 63, "Peru", KnownColor.Peru);
            }
        }

        static public Color Pink
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 192, 203, "Pink", KnownColor.Pink);
            }
        }

        static public Color Plum
        {
            get
            {
                return Color.FromArgbNamed(255, 221, 160, 221, "Plum", KnownColor.Plum);
            }
        }

        static public Color PowderBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 176, 224, 230, "PowderBlue", KnownColor.PowderBlue);
            }
        }

        static public Color Purple
        {
            get
            {
                return Color.FromArgbNamed(255, 128, 0, 128, "Purple", KnownColor.Purple);
            }
        }

        static public Color Red
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 0, 0, "Red", KnownColor.Red);
            }
        }

        static public Color RosyBrown
        {
            get
            {
                return Color.FromArgbNamed(255, 188, 143, 143, "RosyBrown", KnownColor.RosyBrown);
            }
        }

        static public Color RoyalBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 65, 105, 225, "RoyalBlue", KnownColor.RoyalBlue);
            }
        }

        static public Color SaddleBrown
        {
            get
            {
                return Color.FromArgbNamed(255, 139, 69, 19, "SaddleBrown", KnownColor.SaddleBrown);
            }
        }

        static public Color Salmon
        {
            get
            {
                return Color.FromArgbNamed(255, 250, 128, 114, "Salmon", KnownColor.Salmon);
            }
        }

        static public Color SandyBrown
        {
            get
            {
                return Color.FromArgbNamed(255, 244, 164, 96, "SandyBrown", KnownColor.SandyBrown);
            }
        }

        static public Color SeaGreen
        {
            get
            {
                return Color.FromArgbNamed(255, 46, 139, 87, "SeaGreen", KnownColor.SeaGreen);
            }
        }

        static public Color SeaShell
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 245, 238, "SeaShell", KnownColor.SeaShell);
            }
        }

        static public Color Sienna
        {
            get
            {
                return Color.FromArgbNamed(255, 160, 82, 45, "Sienna", KnownColor.Sienna);
            }
        }

        static public Color Silver
        {
            get
            {
                return Color.FromArgbNamed(255, 192, 192, 192, "Silver", KnownColor.Silver);
            }
        }

        static public Color SkyBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 135, 206, 235, "SkyBlue", KnownColor.SkyBlue);
            }
        }

        static public Color SlateBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 106, 90, 205, "SlateBlue", KnownColor.SlateBlue);
            }
        }

        static public Color SlateGray
        {
            get
            {
                return Color.FromArgbNamed(255, 112, 128, 144, "SlateGray", KnownColor.SlateGray);
            }
        }

        static public Color Snow
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 250, 250, "Snow", KnownColor.Snow);
            }
        }

        static public Color SpringGreen
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 255, 127, "SpringGreen", KnownColor.SpringGreen);
            }
        }

        static public Color SteelBlue
        {
            get
            {
                return Color.FromArgbNamed(255, 70, 130, 180, "SteelBlue", KnownColor.SteelBlue);
            }
        }

        static public Color Tan
        {
            get
            {
                return Color.FromArgbNamed(255, 210, 180, 140, "Tan", KnownColor.Tan);
            }
        }

        static public Color Teal
        {
            get
            {
                return Color.FromArgbNamed(255, 0, 128, 128, "Teal", KnownColor.Teal);
            }
        }

        static public Color Thistle
        {
            get
            {
                return Color.FromArgbNamed(255, 216, 191, 216, "Thistle", KnownColor.Thistle);
            }
        }

        static public Color Tomato
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 99, 71, "Tomato", KnownColor.Tomato);
            }
        }

        static public Color Turquoise
        {
            get
            {
                return Color.FromArgbNamed(255, 64, 224, 208, "Turquoise", KnownColor.Turquoise);
            }
        }

        static public Color Violet
        {
            get
            {
                return Color.FromArgbNamed(255, 238, 130, 238, "Violet", KnownColor.Violet);
            }
        }

        static public Color Wheat
        {
            get
            {
                return Color.FromArgbNamed(255, 245, 222, 179, "Wheat", KnownColor.Wheat);
            }
        }

        static public Color White
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 255, 255, "White", KnownColor.White);
            }
        }

        static public Color WhiteSmoke
        {
            get
            {
                return Color.FromArgbNamed(255, 245, 245, 245, "WhiteSmoke", KnownColor.WhiteSmoke);
            }
        }

        static public Color Yellow
        {
            get
            {
                return Color.FromArgbNamed(255, 255, 255, 0, "Yellow", KnownColor.Yellow);
            }
        }

        static public Color YellowGreen
        {
            get
            {
                return Color.FromArgbNamed(255, 154, 205, 50, "YellowGreen", KnownColor.YellowGreen);
            }
        }
    }
}
