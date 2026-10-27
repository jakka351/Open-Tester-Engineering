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
//  Tester Present Specialist Automotive Solutions — Calibration Store (field-validated constants)
//
//  Per-platform calibration overrides accumulated from bench/vehicle characterisation,
//  keyed by (platformId, key).  A value marked Validated here has been confirmed
//  against a real fault on a real vehicle, so a module reading it may drop its
//  advisory posture (per the owner decision: promote findings when the data is real
//  AND validated).  Values that stay spec-seeded keep the finding advisory.
//
//  JSON-backed (NOT SQLite) at %LOCALAPPDATA%\TesterPresent\calibration.json — the
//  same persistence pattern as FleetDistributionStore.  Thread-safe; a failed load
//  leaves an empty store and never throws.  When empty (the common first-run case)
//  it changes nothing: the spec-seeded FordFg/Generic calibrations are used unchanged.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Stores
{
    /// <summary>Thread-safe, JSON-backed store of per-platform validated calibration constants.</summary>
    public sealed class CalibrationStore
    {
        /// <summary>One persisted calibration override.</summary>
        private sealed class Entry
        {
            public string Platform { get; set; }
            public string Key { get; set; }
            public double Value { get; set; }
            public bool Validated { get; set; }
            public string Source { get; set; }
        }

        private readonly object _lock = new object();
        // platformId -> (key -> Entry)
        private readonly Dictionary<string, Dictionary<string, Entry>> _byPlatform =
            new Dictionary<string, Dictionary<string, Entry>>(StringComparer.OrdinalIgnoreCase);
        private readonly string _path;
        private bool _dirty;

        public CalibrationStore() : this(DefaultPath()) { }

        public CalibrationStore(string path)
        {
            _path = string.IsNullOrWhiteSpace(path) ? DefaultPath() : path;
            Load();
        }

        private static string DefaultPath()
        {
            try
            {
                string root = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return System.IO.Path.Combine(root, "TesterPresent", "calibration.json");
            }
            catch { return "calibration.json"; }
        }

        public string Path => _path;

        /// <summary>True if the store holds any override for the platform.</summary>
        public bool HasPlatform(string platformId)
        {
            if (string.IsNullOrEmpty(platformId)) return false;
            lock (_lock)
            {
                return _byPlatform.TryGetValue(platformId, out var d) && d.Count > 0;
            }
        }

        /// <summary>Materialise a platform's overrides as calibration values, or null if none.</summary>
        public IReadOnlyDictionary<string, CalibrationValue> GetPlatform(string platformId)
        {
            if (string.IsNullOrEmpty(platformId)) return null;
            lock (_lock)
            {
                if (!_byPlatform.TryGetValue(platformId, out var d) || d.Count == 0) return null;
                var result = new Dictionary<string, CalibrationValue>(StringComparer.OrdinalIgnoreCase);
                foreach (var kv in d)
                    result[kv.Key] = new CalibrationValue(kv.Value.Value, kv.Value.Validated,
                        string.IsNullOrEmpty(kv.Value.Source) ? "field" : kv.Value.Source);
                return result;
            }
        }

        /// <summary>Record (or update) one calibration override.</summary>
        public void Set(string platformId, string key, double value, bool validated, string source)
        {
            if (string.IsNullOrEmpty(platformId) || string.IsNullOrEmpty(key)) return;
            lock (_lock)
            {
                if (!_byPlatform.TryGetValue(platformId, out var d))
                {
                    d = new Dictionary<string, Entry>(StringComparer.OrdinalIgnoreCase);
                    _byPlatform[platformId] = d;
                }
                d[key] = new Entry { Platform = platformId, Key = key, Value = value, Validated = validated, Source = source };
                _dirty = true;
            }
        }

        /// <summary>Flush buffered writes to disk.  Guarded — a failure never surfaces.</summary>
        public void Flush()
        {
            List<Entry> snapshot;
            lock (_lock)
            {
                if (!_dirty) return;
                snapshot = new List<Entry>();
                foreach (var d in _byPlatform.Values) snapshot.AddRange(d.Values);
                _dirty = false;   // cleared under lock; a concurrent Set re-dirties
            }
            try
            {
                string dir = System.IO.Path.GetDirectoryName(_path);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) Directory.CreateDirectory(dir);
                File.WriteAllText(_path, JsonConvert.SerializeObject(snapshot, Formatting.Indented));
            }
            catch { lock (_lock) { _dirty = true; } }
        }

        /// <summary>Load existing JSON if present.  Missing/corrupt ⇒ empty store, never throws.</summary>
        public void Load()
        {
            try
            {
                if (!File.Exists(_path)) return;
                string json = File.ReadAllText(_path);
                if (string.IsNullOrWhiteSpace(json)) return;
                var loaded = JsonConvert.DeserializeObject<List<Entry>>(json);
                if (loaded == null) return;
                lock (_lock)
                {
                    _byPlatform.Clear();
                    foreach (var e in loaded)
                    {
                        if (e == null || string.IsNullOrEmpty(e.Platform) || string.IsNullOrEmpty(e.Key)) continue;
                        if (!_byPlatform.TryGetValue(e.Platform, out var d))
                        {
                            d = new Dictionary<string, Entry>(StringComparer.OrdinalIgnoreCase);
                            _byPlatform[e.Platform] = d;
                        }
                        d[e.Key] = e;
                    }
                    _dirty = false;
                }
            }
            catch { lock (_lock) { _byPlatform.Clear(); _dirty = false; } }
        }
    }
}
