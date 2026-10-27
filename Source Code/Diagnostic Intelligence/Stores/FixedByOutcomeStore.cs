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
//  Tester Present Specialist Automotive Solutions — Fixed-By Outcome Store (P6)
//
//  Persistent, JSON-backed record of which fix action resolved each symptom on a
//  given platform.  Feeds Bayesian priors into M6: "on FG PCM, symptom X was
//  fixed by action Y in 7 of 9 attempts".  An empty store simply means M6 falls
//  back to its expert priors — this primitive seeds nothing.
//
//  Storage model:
//    key      = platform + '|' + symptomKey
//    value    = fixAction -> (count, successCount)
//  Record() increments count, and successCount when the fix succeeded.  Query()
//  returns FixOutcome rows sorted by SuccessRate desc, then Count desc.
//
//  Thread-safe (single lock).  All I/O is guarded — a corrupt or missing file
//  yields an empty store, never an exception.  Backed at
//  %LOCALAPPDATA%\TesterPresent\fixed_by.json.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.Stores
{
    /// <summary>
    /// JSON-backed, thread-safe implementation of <see cref="IFixedByStore"/>.
    /// Records repair outcomes per (platform, symptom) and reports each candidate
    /// fix action's attempt count and success rate for M6's Bayesian priors.
    /// </summary>
    public sealed class FixedByOutcomeStore : IFixedByStore
    {
        /// <summary>One fix action's running tally within a symptom cell.</summary>
        private sealed class Tally
        {
            public int Count;
            public int SuccessCount;
        }

        private readonly object _gate = new object();
        // outer key = "platform|symptomKey"; inner key = fixAction
        private readonly Dictionary<string, Dictionary<string, Tally>> _cells =
            new Dictionary<string, Dictionary<string, Tally>>(StringComparer.OrdinalIgnoreCase);

        private readonly string _path;
        private bool _dirty;

        /// <summary>Absolute path to the JSON backing file.</summary>
        public string Path => _path;

        /// <summary>Total number of distinct fix-action outcomes recorded across all cells.</summary>
        public int OutcomeCount
        {
            get
            {
                lock (_gate)
                {
                    int n = 0;
                    foreach (var cell in _cells.Values) n += cell.Count;
                    return n;
                }
            }
        }

        /// <summary>Create a store at the default path
        /// (%LOCALAPPDATA%\TesterPresent\fixed_by.json) and load any existing data.</summary>
        public FixedByOutcomeStore() : this(DefaultPath()) { }

        /// <summary>Create a store at an explicit path and load any existing data.</summary>
        /// <param name="path">Absolute path to the JSON backing file.</param>
        public FixedByOutcomeStore(string path)
        {
            _path = string.IsNullOrWhiteSpace(path) ? DefaultPath() : path;
            Load();
        }

        private static string DefaultPath()
        {
            try
            {
                string root = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return System.IO.Path.Combine(root, "TesterPresent", "fixed_by.json");
            }
            catch
            {
                return "fixed_by.json";
            }
        }

        private static string MakeKey(string platform, string symptomKey)
        {
            string p = string.IsNullOrWhiteSpace(platform) ? "?" : platform.Trim();
            string s = string.IsNullOrWhiteSpace(symptomKey) ? "?" : symptomKey.Trim();
            return p + "|" + s;
        }

        /// <summary>
        /// Record one repair outcome: increments the attempt count for
        /// <paramref name="fixAction"/> under (platform, symptom), and the success
        /// count when <paramref name="success"/> is true.  No-op on a blank fix action.
        /// </summary>
        public void Record(string platform, string symptomKey, string fixAction, bool success)
        {
            if (string.IsNullOrWhiteSpace(fixAction)) return;
            string key = MakeKey(platform, symptomKey);
            string action = fixAction.Trim();

            lock (_gate)
            {
                if (!_cells.TryGetValue(key, out var cell))
                {
                    cell = new Dictionary<string, Tally>(StringComparer.OrdinalIgnoreCase);
                    _cells[key] = cell;
                }
                if (!cell.TryGetValue(action, out var tally))
                {
                    tally = new Tally();
                    cell[action] = tally;
                }
                tally.Count++;
                if (success) tally.SuccessCount++;
                _dirty = true;
            }
        }

        /// <summary>
        /// Return the recorded fix outcomes for (platform, symptom), sorted by
        /// success rate (desc) then attempt count (desc).  Empty list if unseen.
        /// </summary>
        public IReadOnlyList<FixOutcome> Query(string platform, string symptomKey)
        {
            string key = MakeKey(platform, symptomKey);
            lock (_gate)
            {
                if (!_cells.TryGetValue(key, out var cell) || cell.Count == 0)
                    return Array.Empty<FixOutcome>();

                return cell
                    .Select(kv => new FixOutcome
                    {
                        FixAction = kv.Key,
                        Count = kv.Value.Count,
                        SuccessCount = kv.Value.SuccessCount,
                    })
                    .OrderByDescending(o => o.SuccessRate)
                    .ThenByDescending(o => o.Count)
                    .ThenBy(o => o.FixAction, StringComparer.OrdinalIgnoreCase)
                    .ToList();
            }
        }

        /// <summary>
        /// Load the backing file into memory, replacing the current contents.
        /// A missing or malformed file leaves the store empty; never throws.
        /// </summary>
        public void Load()
        {
            lock (_gate)
            {
                _cells.Clear();
                _dirty = false;
                try
                {
                    if (!File.Exists(_path)) return;
                    string json = File.ReadAllText(_path);
                    if (string.IsNullOrWhiteSpace(json)) return;

                    var root = JObject.Parse(json);
                    var cellsObj = root["cells"] as JObject;
                    if (cellsObj == null) return;

                    foreach (var cellProp in cellsObj.Properties())
                    {
                        if (!(cellProp.Value is JObject actionsObj)) continue;
                        var cell = new Dictionary<string, Tally>(StringComparer.OrdinalIgnoreCase);
                        foreach (var actProp in actionsObj.Properties())
                        {
                            if (!(actProp.Value is JObject tObj)) continue;
                            int count = tObj.Value<int?>("count") ?? 0;
                            int success = tObj.Value<int?>("success") ?? 0;
                            if (count < 0) count = 0;
                            if (success < 0) success = 0;
                            if (success > count) success = count;
                            if (count == 0) continue;
                            cell[actProp.Name] = new Tally { Count = count, SuccessCount = success };
                        }
                        if (cell.Count > 0) _cells[cellProp.Name] = cell;
                    }
                }
                catch
                {
                    // Corrupt or unreadable file: start clean rather than fail.
                    _cells.Clear();
                }
            }
        }

        /// <summary>
        /// Persist the in-memory state to the backing file.  Guarded — an I/O
        /// failure is swallowed (the store keeps working in memory).
        /// </summary>
        public void Flush()
        {
            lock (_gate)
            {
                if (!_dirty && File.Exists(_path)) return;
                try
                {
                    var cellsObj = new JObject();
                    foreach (var cellKv in _cells)
                    {
                        var actionsObj = new JObject();
                        foreach (var actKv in cellKv.Value)
                        {
                            actionsObj[actKv.Key] = new JObject
                            {
                                ["count"] = actKv.Value.Count,
                                ["success"] = actKv.Value.SuccessCount,
                            };
                        }
                        cellsObj[cellKv.Key] = actionsObj;
                    }

                    var root = new JObject
                    {
                        ["version"] = 1,
                        ["savedUtc"] = DateTime.UtcNow.ToString("o"),
                        ["cells"] = cellsObj,
                    };

                    string dir = System.IO.Path.GetDirectoryName(_path);
                    if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                        Directory.CreateDirectory(dir);

                    // Atomic: temp-then-swap. A torn WriteAllText corrupts fixed_by.json and the
                    // next Load wipes M6's learned repair-outcome priors to empty with no warning.
                    string tmp = _path + ".tmp";
                    File.WriteAllText(tmp, root.ToString(Formatting.Indented));
                    if (File.Exists(_path)) File.Replace(tmp, _path, null);
                    else File.Move(tmp, _path);
                    _dirty = false;
                }
                catch
                {
                    // Disk full / locked / permission denied — keep in-memory state.
                }
            }
        }
    }
}
