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
//  Tester Present Specialist Automotive Solutions — Diagnostic Results Viewer (read-only)
//
//  A compact, read-only findings viewer used when an EXISTING live-data dialog
//  (Relative Compression, Live Combustion Map, …) hands its already-captured data
//  to the intelligence engine and wants to show the ranked hypotheses without
//  re-capturing.  Reuses the same FindingCard + EvidenceChainRenderer as the full
//  workbench so the presentation is identical; it just omits capture and the
//  active-control confirmation loop (that stays in the full workbench).
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TesterPresent.OBD2.Intelligence.UI
{
    /// <summary>Modal read-only viewer for a <see cref="DiagnosticRunResult"/>.</summary>
    public sealed class DiagnosticResultsDialog : Form
    {
        private FlowLayoutPanel _findings;
        private Panel _detailHost;
        private Label _lblHypothesis, _lblAdvisory, _lblNextTest, _lblSuspects, _counter;
        private EvidenceChainRenderer _renderer;
        private FindingCard _selectedCard;
        private DiagnosticResult _selectedResult;
        private readonly DiagnosticRunResult _run;
        private readonly string _subtitle;

        public DiagnosticResultsDialog(DiagnosticRunResult run, string subtitle)
        {
            _run = run;
            _subtitle = subtitle ?? "Findings from the captured data";
            Text = "Diagnostic Intelligence — Results";
            ClientSize = new Size(1080, 680);
            MinimumSize = new Size(900, 520);
            DiTheme.ApplyChrome(this);
            BuildUi();
            Populate();
        }

        private void BuildUi()
        {
            var root = DiTheme.MakeRoot();
            root.Controls.Add(DiTheme.MakeBanner("Diagnostic Intelligence", _subtitle, out _counter), 0, 0);

            var content = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 1, BackColor = DiTheme.BG_DARK, Padding = new Padding(10) };
            content.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 440));
            content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            root.Controls.Add(content, 0, 1);

            _findings = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, WrapContents = false, AutoScroll = true, BackColor = DiTheme.BG_PANEL, Padding = new Padding(8) };
            _findings.Resize += (s, e) => ResizeCards();
            content.Controls.Add(_findings, 0, 0);

            _detailHost = new Panel { Dock = DockStyle.Fill, AutoScroll = true, BackColor = DiTheme.BG_PANEL, Padding = new Padding(12) };
            _lblSuspects = new Label { Dock = DockStyle.Top, Font = DiTheme.UiFont, ForeColor = DiTheme.FG_SECOND, AutoSize = false, Height = 48 };
            _lblNextTest = new Label { Dock = DockStyle.Top, Font = DiTheme.UiBold, ForeColor = DiTheme.ACCENT_BLUE, AutoSize = false, Height = 84 };
            _renderer = new EvidenceChainRenderer { Dock = DockStyle.Top, HeaderText = "Evidence", Height = 220, BackColor = DiTheme.BG_PANEL };
            _lblAdvisory = new Label { Dock = DockStyle.Top, Font = DiTheme.UiSmallBold, ForeColor = DiTheme.ACCENT_AMB, AutoSize = false, Height = 34 };
            _lblHypothesis = new Label { Dock = DockStyle.Top, Font = DiTheme.Title, ForeColor = DiTheme.FG_PRIMARY, AutoSize = false, Height = 56 };
            _detailHost.Controls.Add(_lblSuspects);
            _detailHost.Controls.Add(_lblNextTest);
            _detailHost.Controls.Add(_renderer);
            _detailHost.Controls.Add(_lblAdvisory);
            _detailHost.Controls.Add(_lblHypothesis);
            content.Controls.Add(_detailHost, 1, 0);

            // Parent the layout onto the form — without this the client area is blank.
            Controls.Add(root);
        }

        private void Populate()
        {
            _findings.Controls.Clear();
            if (_run == null || _run.Results == null || _run.Results.Count == 0)
            {
                var none = new Label { Text = "No findings — the captured data did not trip any module.\nThis is a clean result, not an error.", Dock = DockStyle.Top, Height = 60, ForeColor = DiTheme.FG_DIM, Font = DiTheme.UiFont };
                _findings.Controls.Add(none);
                return;
            }
            foreach (var r in _run.Results)
            {
                var card = new FindingCard(r);
                card.Click += (s, e) => Select(card);
                _findings.Controls.Add(card);
            }
            ResizeCards();
            Select(_findings.Controls.OfType<FindingCard>().FirstOrDefault());
        }

        private void Select(FindingCard card)
        {
            if (card == null) return;
            if (_selectedCard != null) _selectedCard.Selected = false;
            _selectedCard = card;
            _selectedCard.Selected = true;
            _selectedResult = card.Result;
            var r = _selectedResult;
            _lblHypothesis.Text = $"[{r.ModuleId}] {r.Hypothesis}";
            _lblAdvisory.Text = r.Advisory ? "⚠ Advisory — " + (r.AdvisoryReason ?? "spec-seeded thresholds, not validated on this vehicle") : "";
            _renderer.Chain = r.Evidence;
            _renderer.Height = Math.Max(120, (r.Evidence?.Count ?? 0) * 46 + 44);
            _lblNextTest.Text = "NEXT TEST\n" + (r.NextTest ?? "—");
            _lblSuspects.Text = (r.SuspectComponents != null && r.SuspectComponents.Count > 0)
                ? "Suspect components: " + string.Join(", ", r.SuspectComponents) : "";
        }

        private void ResizeCards()
        {
            int w = _findings.ClientSize.Width - 8;
            if (w < 80) return;
            foreach (Control c in _findings.Controls) if (c is FindingCard) c.Width = w;
        }

        /// <summary>
        /// Convenience: build an engine (with optional stores), run it over the
        /// snapshot, and show the results dialog.  Used by the fold-in buttons on
        /// the existing live-data dialogs.  Returns immediately after the modal closes.
        /// </summary>
        public static void RunAndShow(IWin32Window owner, DiagnosticSnapshot snapshot, string subtitle)
        {
            IntelligenceBootstrap.EnsureRegistered();
            var engine = new DiagnosticEngine().RegisterBuiltIns();
            var run = engine.Run(snapshot);
            using (var dlg = new DiagnosticResultsDialog(run, subtitle))
                dlg.ShowDialog(owner);
        }
    }
}
