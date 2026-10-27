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
//  Tester Present Specialist Automotive Solutions — Operating-Point Grid
//
//  Generic N×M binning grid over any two continuous signals (RPM × Load,
//  Speed × Throttle, MAP × RPM, …).  Each cell accumulates a running
//  mean+variance of a third "sample" quantity via WelfordAccumulator
//  (SignalMath.cs) — so a consumer can ask, for any operating point, "what is
//  the mean and spread of signal S when the engine is in this RPM/Load cell?".
//
//  This replaces the hard-coded 16×16 grid buried in LiveCombustionMapDialog
//  with a reusable primitive.  Consumers: M1 (misfire topology), M4 (fuel-trim
//  surface), T3 (VE-drift prognostics), T4 (combustion-quality map).
//
//  Cells are stored as a value-type WelfordAccumulator[nx,ny] and mutated in
//  place (load → Add → store) because WelfordAccumulator is a mutable struct.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;

namespace TesterPresent.OBD2.Intelligence
{
    /// <summary>
    /// A rectangular grid that bins two continuous signals (X and Y) into
    /// <see cref="Nx"/>×<see cref="Ny"/> cells, each holding an online
    /// mean/variance accumulator for a sampled quantity.  Out-of-range inputs
    /// are clamped into the edge cells rather than dropped, so a value at or
    /// beyond a boundary still lands in the nearest valid bin.
    /// </summary>
    public sealed class OperatingPointGrid
    {
        private readonly WelfordAccumulator[,] _cells;
        private readonly double _xMin;
        private readonly double _xMax;
        private readonly double _yMin;
        private readonly double _yMax;
        private readonly double _xSpan;
        private readonly double _ySpan;
        private long _totalCount;

        /// <summary>
        /// Build a grid of <paramref name="nx"/>×<paramref name="ny"/> cells over
        /// the ranges [<paramref name="xMin"/>,<paramref name="xMax"/>] ×
        /// [<paramref name="yMin"/>,<paramref name="yMax"/>].  Cell counts are
        /// clamped to &gt;= 1; inverted ranges are swapped so min &lt;= max.  A
        /// zero-span axis (min == max) collapses that axis to column/row 0.
        /// </summary>
        /// <param name="nx">Number of columns (X bins); clamped to &gt;= 1.</param>
        /// <param name="ny">Number of rows (Y bins); clamped to &gt;= 1.</param>
        /// <param name="xMin">Lower X bound (swapped with xMax if inverted).</param>
        /// <param name="xMax">Upper X bound.</param>
        /// <param name="yMin">Lower Y bound (swapped with yMax if inverted).</param>
        /// <param name="yMax">Upper Y bound.</param>
        /// <param name="xName">Optional human label for the X axis (e.g. "RPM").</param>
        /// <param name="yName">Optional human label for the Y axis (e.g. "Load%").</param>
        public OperatingPointGrid(int nx, int ny, double xMin, double xMax, double yMin, double yMax,
                                  string xName = null, string yName = null)
        {
            Nx = nx < 1 ? 1 : nx;
            Ny = ny < 1 ? 1 : ny;

            if (xMax < xMin) { double t = xMin; xMin = xMax; xMax = t; }
            if (yMax < yMin) { double t = yMin; yMin = yMax; yMax = t; }

            _xMin = xMin;
            _xMax = xMax;
            _yMin = yMin;
            _yMax = yMax;
            _xSpan = xMax - xMin;
            _ySpan = yMax - yMin;

            XName = xName;
            YName = yName;

            _cells = new WelfordAccumulator[Nx, Ny];
        }

        /// <summary>Number of columns (X bins).</summary>
        public int Nx { get; }

        /// <summary>Number of rows (Y bins).</summary>
        public int Ny { get; }

        /// <summary>Human-readable X-axis label, or null.</summary>
        public string XName { get; }

        /// <summary>Human-readable Y-axis label, or null.</summary>
        public string YName { get; }

        /// <summary>Total number of samples binned across all cells.</summary>
        public long TotalCount => _totalCount;

        /// <summary>
        /// Map a continuous (<paramref name="xVal"/>,<paramref name="yVal"/>)
        /// point to its cell indices.  Values are clamped into range, so the
        /// result is always a valid index pair in [0..Nx-1] × [0..Ny-1].  A
        /// zero-span axis always maps to index 0 on that axis.
        /// </summary>
        public (int x, int y) CellOf(double xVal, double yVal)
        {
            return (BinIndex(xVal, _xMin, _xSpan, Nx), BinIndex(yVal, _yMin, _ySpan, Ny));
        }

        /// <summary>
        /// Bin (<paramref name="xVal"/>,<paramref name="yVal"/>) into a cell and
        /// add <paramref name="sample"/> to that cell's running accumulator.
        /// </summary>
        public void Add(double xVal, double yVal, double sample)
        {
            int cx = BinIndex(xVal, _xMin, _xSpan, Nx);
            int cy = BinIndex(yVal, _yMin, _ySpan, Ny);
            // Mutable value-type struct: load a copy, mutate, store it back.
            WelfordAccumulator acc = _cells[cx, cy];
            acc.Add(sample);
            _cells[cx, cy] = acc;
            _totalCount++;
        }

        /// <summary>
        /// Return a copy of the accumulator at cell (<paramref name="x"/>,
        /// <paramref name="y"/>).  Out-of-range indices return a default
        /// (empty) accumulator rather than throwing.
        /// </summary>
        public WelfordAccumulator Cell(int x, int y)
        {
            if (x < 0 || x >= Nx || y < 0 || y >= Ny) return default;
            return _cells[x, y];
        }

        /// <summary>
        /// Convenience: <see cref="CellOf"/> followed by <see cref="Cell"/> —
        /// return a copy of the accumulator covering the operating point
        /// (<paramref name="xVal"/>,<paramref name="yVal"/>).
        /// </summary>
        public WelfordAccumulator CellAt(double xVal, double yVal)
        {
            var (cx, cy) = CellOf(xVal, yVal);
            return _cells[cx, cy];
        }

        /// <summary>Center X value of column <paramref name="x"/> (clamped to a valid column).</summary>
        public double XCenter(int x)
        {
            int c = x < 0 ? 0 : (x >= Nx ? Nx - 1 : x);
            return _xMin + (c + 0.5) * (_xSpan / Nx);
        }

        /// <summary>Center Y value of row <paramref name="y"/> (clamped to a valid row).</summary>
        public double YCenter(int y)
        {
            int c = y < 0 ? 0 : (y >= Ny ? Ny - 1 : y);
            return _yMin + (c + 0.5) * (_ySpan / Ny);
        }

        /// <summary>
        /// Enumerate every cell whose sample count is &gt;= <paramref name="minCount"/>,
        /// yielding its indices and a copy of its accumulator.  Cells are visited
        /// in column-major order (x outer, y inner).
        /// </summary>
        public IEnumerable<(int x, int y, WelfordAccumulator acc)> OccupiedCells(int minCount = 1)
        {
            if (minCount < 1) minCount = 1;
            for (int x = 0; x < Nx; x++)
            {
                for (int y = 0; y < Ny; y++)
                {
                    WelfordAccumulator acc = _cells[x, y];
                    if (acc.Count >= minCount)
                        yield return (x, y, acc);
                }
            }
        }

        /// <summary>Clear every cell and reset the total sample count.</summary>
        public void Reset()
        {
            for (int x = 0; x < Nx; x++)
                for (int y = 0; y < Ny; y++)
                    _cells[x, y] = default;
            _totalCount = 0;
        }

        /// <summary>
        /// Map a scalar into a bin index in [0..n-1].  Values below the range
        /// clamp to 0, values at or above the top clamp to n-1, and a zero-span
        /// axis always returns 0.
        /// </summary>
        private static int BinIndex(double val, double min, double span, int n)
        {
            if (n <= 1 || span <= 0.0) return 0;
            double frac = (val - min) / span;   // 0..1 across the range
            if (frac <= 0.0) return 0;
            if (frac >= 1.0) return n - 1;
            int idx = (int)(frac * n);
            if (idx < 0) return 0;
            if (idx >= n) return n - 1;
            return idx;
        }
    }
}
