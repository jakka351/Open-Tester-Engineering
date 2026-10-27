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
//  Tester Present Specialist Automotive Solutions — Fleet Distribution Store
//
//  Persistent per-platform parameter distributions accumulated across sessions
//  with Welford's algorithm, keyed by (platform, signal, cellX, cellY).  This is
//  the concrete IFleetStore that M4 (fleet baseline) and T3/T7 read from.
//
//  JSON-backed (NOT SQLite) at %LOCALAPPDATA%\TesterPresent\fleet.json to match
//  the existing TES persistence pattern (OemDtcLibrary gzipped-JSON,
//  TelemetryCollector JSON buffer).  Thread-safe.  A failed load leaves an empty
//  store (advisory) and never throws — all I/O is guarded.
//
//  Each cell persists its own Welford state (count, mean, m2, min, max) via the
//  internal CellStat struct so serialisation is lossless; WelfordAccumulator's
//  _m2 is private, so CellStat mirrors its update rule but exposes M2.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Stores
{
    /// <summary>
    /// Thread-safe, JSON-backed implementation of <see cref="IFleetStore"/>.
    /// Distributions accumulate across sessions using Welford's online algorithm,
    /// one running distribution per (platform, signal, cellX, cellY) cell.
    /// </summary>
    public sealed class FleetDistributionStore : IFleetStore
    {
        // ── persisted cell record ─────────────────────────────────────────────

        /// <summary>
        /// One cell's serialisable Welford state.  Mirrors
        /// <see cref="WelfordAccumulator"/> but exposes M2 so the distribution can
        /// round-trip through JSON exactly.
        /// </summary>
        private struct CellStat
        {
            public string Platform;
            public string Signal;
            public int Cx;
            public int Cy;
            public long Count;
            public double Mean;
            public double M2;
            public double Min;
            public double Max;

            /// <summary>Fold one observation into the running distribution.</summary>
            public void Add(double x)
            {
                if (Count == 0) { Min = x; Max = x; }
                else { if (x < Min) Min = x; if (x > Max) Max = x; }
                Count++;
                double delta = x - Mean;
                Mean += delta / Count;
                double delta2 = x - Mean;
                M2 += delta * delta2;
            }

            /// <summary>Sample standard deviation (÷ N-1). Zero for &lt; 2 samples.
            /// The brief specifies the SAMPLE variance for the fleet sigma; the population
            /// form (÷ N) understates the spread and inflates every z-score a consumer
            /// (M4, T7) computes against this cell — worst when the cell is freshly
            /// populated and N is small.</summary>
            public double StdDev => Count > 1 ? Math.Sqrt(M2 / (Count - 1)) : 0.0;
        }

        // ── state ─────────────────────────────────────────────────────────────

        private readonly object _lock = new object();
        private readonly Dictionary<string, CellStat> _cells = new Dictionary<string, CellStat>(StringComparer.Ordinal);
        private readonly string _path;
        private bool _dirty;

        // ── construction ──────────────────────────────────────────────────────

        /// <summary>Create a store at the default path
        /// <c>%LOCALAPPDATA%\TesterPresent\fleet.json</c> and load it if present.</summary>
        public FleetDistributionStore() : this(DefaultPath())
        {
        }

        /// <summary>Create a store at an explicit path (used by tests) and load it
        /// if present.  A missing or corrupt file leaves the store empty.</summary>
        public FleetDistributionStore(string path)
        {
            _path = string.IsNullOrWhiteSpace(path) ? DefaultPath() : path;
            Load();
        }

        private static string DefaultPath()
        {
            try
            {
                string root = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return System.IO.Path.Combine(root, "TesterPresent", "fleet.json");
            }
            catch
            {
                // Last-resort fallback: current directory. Never throw from a ctor path helper.
                return "fleet.json";
            }
        }

        // ── public surface ────────────────────────────────────────────────────

        /// <summary>The JSON file this store persists to.</summary>
        public string Path => _path;

        /// <summary>Distinct (platform, signal, cell) keys currently held.</summary>
        public int CellCount
        {
            get { lock (_lock) { return _cells.Count; } }
        }

        // ── IFleetStore ───────────────────────────────────────────────────────

        /// <summary>Record one observation into the running distribution for a cell.</summary>
        public void Record(string platform, string signal, int cellX, int cellY, double value)
        {
            if (double.IsNaN(value) || double.IsInfinity(value)) return;
            string key = MakeKey(platform, signal, cellX, cellY);
            lock (_lock)
            {
                CellStat stat;
                if (!_cells.TryGetValue(key, out stat))
                {
                    stat = new CellStat
                    {
                        Platform = platform ?? string.Empty,
                        Signal = signal ?? string.Empty,
                        Cx = cellX,
                        Cy = cellY
                    };
                }
                stat.Add(value);
                _cells[key] = stat;
                _dirty = true;
            }
        }

        /// <summary>Query the distribution for a cell; <see cref="FleetStat.Count"/>
        /// is 0 when the cell has never been seen.</summary>
        public FleetStat Query(string platform, string signal, int cellX, int cellY)
        {
            string key = MakeKey(platform, signal, cellX, cellY);
            lock (_lock)
            {
                CellStat stat;
                if (!_cells.TryGetValue(key, out stat))
                    return new FleetStat { Count = 0 };
                return new FleetStat
                {
                    Count = stat.Count,
                    Mean = stat.Mean,
                    StdDev = stat.StdDev,
                    Min = stat.Min,
                    Max = stat.Max
                };
            }
        }

        /// <summary>Total observations recorded for a platform+signal across all cells.</summary>
        public long TotalObservations(string platform, string signal)
        {
            string p = platform ?? string.Empty;
            string s = signal ?? string.Empty;
            long total = 0;
            lock (_lock)
            {
                foreach (var kv in _cells)
                {
                    CellStat st = kv.Value;
                    if (string.Equals(st.Platform, p, StringComparison.Ordinal) &&
                        string.Equals(st.Signal, s, StringComparison.Ordinal))
                        total += st.Count;
                }
            }
            return total;
        }

        /// <summary>Flush buffered writes to disk.  No-op when nothing changed.
        /// Guarded — a write failure is swallowed (advisory persistence).</summary>
        public void Flush()
        {
            List<CellStat> snapshot;
            lock (_lock)
            {
                if (!_dirty) return;
                snapshot = new List<CellStat>(_cells.Values);
                // Clear the dirty flag NOW, while holding the lock and owning this exact
                // snapshot.  A concurrent Record that lands after this point re-sets _dirty,
                // so its data is not lost to a future flush.  (Clearing _dirty AFTER the
                // write, as before, would drop any Record that arrived during the write.)
                _dirty = false;
            }

            try
            {
                string dir = System.IO.Path.GetDirectoryName(_path);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                string json = JsonConvert.SerializeObject(snapshot, Formatting.Indented);
                // Atomic: write to temp then swap in one OS op. A non-atomic WriteAllText that
                // crashes mid-write truncates fleet.json, and the next Load wipes months of
                // accumulated baselines to empty. temp-then-Replace can't leave a torn live file.
                string tmp = _path + ".tmp";
                File.WriteAllText(tmp, json);
                if (File.Exists(_path)) File.Replace(tmp, _path, null);
                else File.Move(tmp, _path);
            }
            catch
            {
                // Persistence is advisory; a failed flush must never surface as an exception.
                // But the snapshot did NOT reach disk, so re-mark dirty so the next Flush
                // retries it rather than silently losing the accumulated data.
                lock (_lock) { _dirty = true; }
            }
        }

        /// <summary>Load existing JSON if present.  Safe if the file is missing or
        /// corrupt — either case leaves the in-memory store empty.</summary>
        public void Load()
        {
            try
            {
                if (!File.Exists(_path)) return;
                string json = File.ReadAllText(_path);
                if (string.IsNullOrWhiteSpace(json)) return;

                var loaded = JsonConvert.DeserializeObject<List<CellStat>>(json);
                if (loaded == null) return;

                lock (_lock)
                {
                    _cells.Clear();
                    foreach (var st in loaded)
                    {
                        // Reject a corrupt-but-parseable cell (negative M2/Count, non-finite
                        // moments) — otherwise StdDev = sqrt(negative) = NaN flows into every
                        // M4/T7 z-score and forces a nonsensical outlier/anomaly verdict.
                        if (st.Count < 0 || st.M2 < 0
                            || double.IsNaN(st.Mean) || double.IsInfinity(st.Mean)
                            || double.IsNaN(st.M2) || double.IsInfinity(st.M2))
                            continue;
                        string key = MakeKey(st.Platform, st.Signal, st.Cx, st.Cy);
                        _cells[key] = st;
                    }
                    _dirty = false;
                }
            }
            catch
            {
                // Corrupt / unreadable file → empty store, never throw.
                lock (_lock) { _cells.Clear(); _dirty = false; }
            }
        }

        // ── helpers ───────────────────────────────────────────────────────────

        private static string MakeKey(string platform, string signal, int cx, int cy)
            => Esc(platform) + '|' + Esc(signal) + '|' + cx + '|' + cy;

        /// <summary>Escape the key delimiter so a platform/signal name that itself contains
        /// a '|' (or the '\' escape) cannot collide two distinct cells onto one key.</summary>
        private static string Esc(string s)
            => (s ?? string.Empty).Replace("\\", "\\\\").Replace("|", "\\|");
    }
}
