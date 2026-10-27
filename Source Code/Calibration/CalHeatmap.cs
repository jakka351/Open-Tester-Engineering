//........................................................................................................................................................................................................................
//..............................::........................................................................................................................................................................................
//...........................:+*****=:....................................................................................................................................................................................
//.......................:=+****=-+****+:.................................................................................................................................................................................
//....................:+*****-::=+-::+****+-..............................................................................................................................................................................
//.................-+****+:...=****+:...-+****=:..........................................................................................................................................................................
//..............-****+=.......-****+.......-+****+:.......................................................................................................................................................................
//..........:=****+-:...........=*:...........:=****+-....................................................................................................................................................................
//.......:*****+:...............-*................=*****=:................................................................................................................................................................
//....-+****=:..................-+...................-+****+:.............................................................................................................................................................
//...+***-:.::..................-*...................:..:+***:............................................................................................#@@@@+..........................................................
//...+**-:=====:................-*.................-====::***:...............#@@@@@@@@@@@@@@@@@@@@@@@@@@:.................................................%@@@@*..........................................................
//...+**-:=====-................-*................:=====-.***:...............#@@@@@@@@@@@@@@@@@@@@@@@@@@:.................................................%@@@@*..........................................................
//...***-..:-:.:---:............-*.............:-=-::--:.:***:...............*%@@@%%%@@@@@@@@@%@@@@@@@%%:.......:::...................:::::...............%@@@@*:.....:.........:::::........................::::.........
//...***:.........:-=-:.......-+***+:.......:-=-:........:***:..........................@@@@@=............:@@@@@@@@@@@@@@@@@#......#@@@@@@@@@@@@@@@@@-....%@@@@@@@@@@@@#....%@@@@@@@@@@@@@@@@%......+@@@@@@@@@@@@@@-......
//...+**-.............---:.-**+=--=+**+::-=-:.............***:..........................@@@@@=...........#@@@@@@@@@@@@@@@@@@@@-..-@@@@@@@@@@@@@@@@@@@@*...%@@@@@@@@@@@@%..=@@@@@@@@@@@@@@@@@@@@=..:@@@@@@@@@@@@@@@@-......
//...***-................:+****:...-+***=:................***:..........................@@@@@=..........-@@@@@@@@@@@@@@@@@@@@@#..%@@@@@@@@@@@@@@@@@@@@@:..%@@@@@@@@@@@@*..%@@@@@@@@@@@@@@@@@@@@@..=@@@@@@@@@@@@@@@@:......
//...***-................-*+..=*+=**:.:**.................***:..........................@@@@@=..........-@@@@@...........+@@@@#..%@@@@+...................%@@@@*..........%@@@@-..........-@@@@@..+@@@@#..................
//...***-................=*=...-***:..:**.................***:..........................@@@@@=..........-@@@@@###########%@@@@#..%@@@@%############*......%@@@@*..........@@@@@%##########%@@@@@..=@@@@#..................
//...***-................:**::**-.+*+:=*+.................***:..........................@@@@@=..........-@@@@@@@@@@@@@@@@@@@@@#..-@@@@@@@@@@@@@@@@@@@@:...%@@@@*..........@@@@@@@@@@@@@@@@@@@@@@..+@@@@#..................
//...***-..............:=*****-.....+****+-...............***:..........................@@@@@=..........-@@@@@@@@@@@@@@@@@@@@@#....%@@@@@@@@@@@@@@@@@@@...%@@@@*..........@@@@@@@@@@@@@@@@@@@@@@..=@@@@#..................
//...***-...........:+*+-...=********+....=**-............***:..........................@@@@@=..........-@@@@@-..................................:@@@@@:..%@@@@*..........@@@@@=..................=@@@@#..................
//...***-........-+*+:.........:-=::........:-**=:.......:***:..........................@@@@@=..........-@@@@@:..................#@@@@-..........:@@@@@:..%@@@@*..........@@@@@=..................+@@@@#..................
//...***-.=***+++=..............:-..............:+++***+::***:..........................@@@@@=..........:@@@@@@@@@@@@@@@@@@@@@#..#@@@@@@@@@@@@@@@@@@@@@:..%@@@@@@@@@@@@#..%@@@@@@@@@@@@@@@@@@@@@..=@@@@#..................
//...+**-:*****=................:-................:*****=:***:..........................@@@@@=...........:@@@@@@@@@@@@@@@@@@@@#..:%@@@@@@@@@@@@@@@@@@@:....#@@@@@@@@@@@%...%@@@@@@@@@@@@@@@@@@@@..=@@@@#..................
//...***-:=**++.................:-.................-***+.:***:..........................@@@@@-.............:%@@@@@@@@@@@@@@@@@*.....#@@@@@@@@@@@@@@@:........*@@@@@@@@@#.....%@@@@@@@@@@@@@@@@@%..=@@@@*..................
//...=****=:....................:-....................:=****+.............................................................................................................................................................
//.....:+****+-.................:=.................:+****+:...............................................................................................................................................................
//........:=****+-..............-=..............:+****+:..................................................................................................................................................................
//............-*****+:.........:==-..........-*****=......................................................................................................................................................................
//...............:+****+:.....-=====.....:=****+-.........................................................................................................................................................................
//...................=*****=:.:====-..:+****+:............................................................................................................................................................................
//......................-+****=:...-+****=:...............................................................................................................................................................................
//.........................:+********+-..........................................................................Tester Present Specialist Automotive Solutions...........................................................
//............................:=+++:......................................................................................................................................................................................
//...................................................... .................................................................................................................................................................
/*
 * Tester Engineering Suite Source Code
 * ------------------------------------------------------------
 * FILE PURPOSE
 * ------------------------------------------------------------
 * This file forms part of the proprietary Tester Engineering Suite
 * software developed by Tester Present Specialist Automotive Solutions.
 * ------------------------------------------------------------
 * COPYRIGHT & OWNERSHIP
 * ------------------------------------------------------------
 * Copyright (c) 2026 Jack Leighton
 * Tester Present Specialist Automotive Solutions
 *
 * This file and its contents are proprietary and confidential.
 * All intellectual property rights in the original code, architecture,
 * implementation, modifications, and associated documentation are
 * reserved by the copyright holder.
 * ------------------------------------------------------------
 * PROPRIETARY LICENSE
 * ------------------------------------------------------------
 * This software is licensed, not sold.
 *
 * No permission is granted to any person or entity to copy, reproduce,
 * modify, adapt, translate, publish, distribute, sublicense, disclose,
 * reverse engineer, decompile, or create derivative works from this
 * file, in whole or in part, except where expressly authorised in
 * writing by the copyright holder or permitted by applicable law.
 *
 * Access to, possession of, or use of this file does not grant any
 * ownership interest or intellectual property rights in the software.
 *
 * Use, installation, and distribution of this software are subject
 * to the applicable Tester Engineering Suite EULA.
 * ------------------------------------------------------------
 * CONFIDENTIALITY NOTICE
 * ------------------------------------------------------------
 * This file may contain commercially sensitive implementation details,
 * proprietary algorithms, internal interfaces, security mechanisms,
 * and trade secrets belonging to Tester Present Specialist
 * Automotive Solutions.
 *
 * Unauthorised access, disclosure, copying, or distribution is
 * prohibited to the extent permitted by applicable law.
 * ------------------------------------------------------------
 * PRODUCT IDENTIFICATION
 * ------------------------------------------------------------
 * Product:       Tester Engineering Suite (TES)
 * Developer:     Tester Present Specialist Automotive Solutions
 * Jurisdiction:  Australia
 * ------------------------------------------------------------
 */
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//  Tester Present Specialist Automotive Solutions — Calibration Workbench
//
//  CalHeatmap.cs — the thermal colour palette shared by the table grid and the 3-D surface.
//  Maps a normalised value [0..1] across a smooth green → yellow → orange → red gradient so a
//  map's shape reads instantly, and picks a legible text colour for any background by
//  luminance.  One palette everywhere keeps the grid and the 3-D view perfectly consistent.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Drawing;

namespace TesterPresent.OBD2.Calibration
{
    public static class CalHeatmap
    {
        // Cold → hot control points.  A green → red thermal ramp: vivid and evenly spaced so a
        // map's shape reads at a glance, with endpoints kept bright enough that cell text stays
        // legible.  No blue end — the scale runs green (low) through yellow/orange to red (high).
        private static readonly (double pos, Color col)[] Stops =
        {
            (0.00, Color.FromArgb( 35, 170,  75)),  // green (cold)
            (0.25, Color.FromArgb(120, 205,  65)),  // yellow-green
            (0.50, Color.FromArgb(225, 215,  50)),  // yellow
            (0.75, Color.FromArgb(245, 150,  40)),  // orange
            (1.00, Color.FromArgb(220,  45,  45)),  // red
        };

        /// <summary>Colour for a normalised value (0 = coldest, 1 = hottest).</summary>
        public static Color Color01(double t)
        {
            if (double.IsNaN(t)) return Color.FromArgb(60, 64, 74);
            if (t <= 0) return Stops[0].col;
            if (t >= 1) return Stops[Stops.Length - 1].col;
            for (int i = 1; i < Stops.Length; i++)
            {
                if (t <= Stops[i].pos)
                {
                    double span = Stops[i].pos - Stops[i - 1].pos;
                    double f = span <= 0 ? 0 : (t - Stops[i - 1].pos) / span;
                    return Lerp(Stops[i - 1].col, Stops[i].col, f);
                }
            }
            return Stops[Stops.Length - 1].col;
        }

        /// <summary>Colour for a value within [min..max].</summary>
        public static Color ColorFor(double value, double min, double max)
        {
            if (double.IsNaN(value) || double.IsInfinity(value)) return Color.FromArgb(60, 64, 74);
            double range = max - min;
            double t = Math.Abs(range) < 1e-12 ? 0.5 : (value - min) / range;
            return Color01(Math.Max(0, Math.Min(1, t)));
        }

        public static Color TextOn(Color bg)
        {
            double lum = (0.299 * bg.R + 0.587 * bg.G + 0.114 * bg.B);
            return lum > 150 ? Color.FromArgb(20, 24, 30) : Color.FromArgb(245, 248, 252);
        }

        /// <summary>
        /// Robust display range that ignores sentinel / "disabled" cells (a map padded with
        /// 0xFFFF, a shift map with a 17990 plateau, …) which would otherwise stretch the scale
        /// so far that all the real data collapses into one cold colour.  Uses Tukey fences
        /// (q1 − k·IQR … q3 + k·IQR) to decide what counts as an outlier, then snaps the range
        /// to the actual min/max of the *inliers* — so the genuine data spans the whole gradient
        /// and only the outliers saturate at the ends.  Falls back to true min/max for tiny
        /// samples or when one value dominates the middle of the distribution (a flat plateau).
        /// </summary>
        public static bool RobustRange(IEnumerable<double> values, out double lo, out double hi, double k = 1.5)
        {
            lo = 0; hi = 1;
            if (values == null) return false;

            var list = new List<double>();
            foreach (var v in values)
                if (!double.IsNaN(v) && !double.IsInfinity(v)) list.Add(v);
            if (list.Count == 0) return false;

            list.Sort();
            double trueMin = list[0], trueMax = list[list.Count - 1];

            if (list.Count < 8 || trueMax - trueMin < 1e-12)
            {
                lo = trueMin; hi = trueMax;
                if (hi - lo < 1e-12) hi = lo + 1;
                return true;
            }

            double q1 = Percentile(list, 0.25);
            double q3 = Percentile(list, 0.75);
            double iqr = q3 - q1;

            if (iqr < (trueMax - trueMin) * 1e-3)
            {
                // One value owns the middle of the distribution (flat plateau) — IQR is useless.
                lo = trueMin; hi = trueMax;
            }
            else
            {
                double lowerFence = q1 - k * iqr;
                double upperFence = q3 + k * iqr;
                // list is sorted: snap to the extent of the values that fall inside the fences.
                int hiIdx = list.Count - 1;
                while (hiIdx > 0 && list[hiIdx] > upperFence) hiIdx--;
                int loIdx = 0;
                while (loIdx < hiIdx && list[loIdx] < lowerFence) loIdx++;
                lo = list[loIdx]; hi = list[hiIdx];
            }
            if (hi - lo < 1e-12) hi = lo + 1;
            return true;
        }

        private static double Percentile(List<double> sorted, double p)
        {
            if (sorted.Count == 1) return sorted[0];
            p = Math.Max(0, Math.Min(1, p));
            double idx = p * (sorted.Count - 1);
            int i = (int)Math.Floor(idx);
            double frac = idx - i;
            return i + 1 < sorted.Count ? sorted[i] + (sorted[i + 1] - sorted[i]) * frac
                                        : sorted[i];
        }

        private static Color Lerp(Color a, Color b, double f)
        {
            f = Math.Max(0, Math.Min(1, f));
            return Color.FromArgb(
                (int)(a.R + (b.R - a.R) * f),
                (int)(a.G + (b.G - a.G) * f),
                (int)(a.B + (b.B - a.B) * f));
        }

        public static Color Shade(Color c, double factor)
        {
            // NaN/Infinity would survive Math.Max/Min (both propagate NaN) and crash Color.FromArgb
            // via (int)NaN == int.MinValue — so a bad factor means "leave the colour unshaded".
            if (double.IsNaN(factor) || double.IsInfinity(factor)) return c;
            factor = Math.Max(0, Math.Min(2, factor));
            return Color.FromArgb(
                (int)Math.Max(0, Math.Min(255, c.R * factor)),
                (int)Math.Max(0, Math.Min(255, c.G * factor)),
                (int)Math.Max(0, Math.Min(255, c.B * factor)));
        }
    }
}
