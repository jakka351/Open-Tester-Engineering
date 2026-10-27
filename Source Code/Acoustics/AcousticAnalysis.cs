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
//  Tester Present Specialist Automotive Solutions — Acoustic Diagnostics: order analysis + peaks
//  Copyright (c) 2026 Benjamin Jack Leighton. All rights reserved.
//
//  RPM-locked order mapping and spectral peak detection. This is the TES differentiator: because
//  the app already has a live OBD link, a spectral peak can be expressed as a CRANK ORDER
//  (peakHz ÷ RPM/60) rather than a bare frequency, so the operator sees whether a tone tracks the
//  engine (order stays constant as RPM changes), tracks road speed, or stays put (not the engine).
//  The named-order table mirrors Intelligence\Tier2\T6_VibrationMonitor's mechanical signatures.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace TesterPresent.OBD2.Acoustics
{
    public struct AcousticPeak
    {
        public double FreqHz;
        public double Db;
        public double Order;       // NaN when RPM unknown
        public string OrderLabel;  // "" when RPM unknown
    }

    public static class AcousticAnalysis
    {
        /// <summary>Vertical order cursors to draw, given the engine's cylinder count.</summary>
        public static IEnumerable<(double order, string label, bool emphasize)> OrderCursors(int cylinders)
        {
            yield return (0.5, "0.5×", false);
            yield return (1.0, "1×", true);          // crank rotation
            yield return (2.0, "2×", false);
            double firing = cylinders > 0 ? cylinders / 2.0 : 2.0;   // 4-stroke combustion events / rev
            yield return (firing, "fire", true);
            yield return (firing * 2.0, "2·fire", false);
        }

        /// <summary>Best-effort name for a crank order (drives the peak-table "Note" column).</summary>
        public static string OrderName(double order, int cylinders)
        {
            if (double.IsNaN(order) || order <= 0) return "";
            double firing = cylinders > 0 ? cylinders / 2.0 : 2.0;
            if (Near(order, firing, 0.12)) return "firing / combustion";
            if (Near(order, 0.25, 0.06)) return "valvetrain (¼)";
            if (Near(order, 0.5, 0.08)) return "cam / half-order";
            if (Near(order, 1.0, 0.10)) return "crank 1st (imbalance)";
            if (Near(order, 2.0, 0.12)) return "crank 2nd";
            if (Near(order, 3.0, 0.15)) return "3rd order";
            if (Near(order, 4.0, 0.18)) return "4th order";
            return "";
        }

        private static bool Near(double v, double target, double tol) => Math.Abs(v - target) <= tol;

        /// <summary>
        /// Local-maxima peak detection over one-sided magnitude in dB. A bin is a peak if it exceeds
        /// both neighbours and sits at least <paramref name="prominenceDb"/> above the local median
        /// floor. Returns the strongest <paramref name="maxPeaks"/>, each tagged with crank order when
        /// <paramref name="rpm"/> &gt; 0.
        /// </summary>
        public static List<AcousticPeak> FindPeaks(
            float[] magDb, int usableBins, double sampleRate, int fftSize,
            double rpm, int cylinders, double prominenceDb, int maxPeaks,
            double minHz, double maxHz)
        {
            var found = new List<AcousticPeak>();
            if (magDb == null || usableBins < 4) return found;

            int loBin = Math.Max(1, (int)Math.Floor(minHz * fftSize / sampleRate));
            int hiBin = Math.Min(usableBins - 1, (int)Math.Ceiling(maxHz * fftSize / sampleRate));

            // Rolling local floor (median-ish via a windowed minimum-plus-margin is noisy; use a
            // wide moving average of dB as the reference, which the tone must clear by prominenceDb).
            int win = Math.Max(8, (hiBin - loBin) / 48);
            for (int k = loBin + 1; k < hiBin - 1; k++)
            {
                float v = magDb[k];
                if (v < magDb[k - 1] || v < magDb[k + 1]) continue;   // not a local max

                int a = Math.Max(loBin, k - win), b = Math.Min(hiBin, k + win);
                double sum = 0; int n = 0;
                for (int j = a; j <= b; j++) { sum += magDb[j]; n++; }
                double floorDb = n > 0 ? sum / n : v;
                if (v - floorDb < prominenceDb) continue;

                double hz = AcousticFft.BinToHz(k, sampleRate, fftSize);
                double order = rpm > 1 ? hz / (rpm / 60.0) : double.NaN;
                found.Add(new AcousticPeak
                {
                    FreqHz = hz,
                    Db = v,
                    Order = order,
                    OrderLabel = double.IsNaN(order) ? "" : order.ToString("0.00") + "×",
                });
            }

            found.Sort((p, q) => q.Db.CompareTo(p.Db));
            if (found.Count > maxPeaks) found.RemoveRange(maxPeaks, found.Count - maxPeaks);
            return found;
        }
    }
}
