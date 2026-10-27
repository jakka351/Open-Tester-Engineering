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
//  Tester Present Specialist Automotive Solutions — Diagnostic Intelligence Workbench
//
//  The operator-facing surface for the two-tier Diagnostic Intelligence Layer.
//  A mechanic picks a GUIDED CAPTURE PROFILE (Idle Health, Drive Sample, Crank &
//  Start, Network Scan, Full) — each tells them what to do and captures the right
//  window for the modules that consume it — then the DiagnosticEngine runs every
//  applicable Tier-1/Tier-2 module and ranks the fault hypotheses.
//
//  Each finding is a scannable card (severity stripe + confidence bar). Selecting
//  it shows the EVIDENCE CHAIN that produced it, the suspect components, and the
//  single most discriminating NEXT TEST — which, when the module emits an
//  executable ConfirmationScript, can be RUN from here through the safety-gated
//  ConfirmationRunner (arming + per-step confirmation + a hard block on any
//  restraints/airbag module).
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using J2534;
using TesterPresent.OBD2.Controls;
using TesterPresent.OBD2.UDS;
using TesterPresent.OBD2.Intelligence;

namespace TesterPresent.OBD2.Intelligence.UI
{
    /// <summary>Advanced-Diagnostics workbench: guided capture → engine → evidence → confirmation.</summary>
    public sealed class DiagnosticIntelligenceDialog : Form
    {
        private readonly J2534Manager _j2534;
        private readonly UDSManager _uds;
        private readonly OBDonUDSManager _obd;
        private readonly string _detectedVin;
        /// <summary>Supplies the CAN Topographer's last scan (the live per-VIN CAN map)
        /// so DIAGINTEL reuses real bus/gateway/DTC topology instead of a stub probe.
        /// Null in headless/MCP contexts; capture then falls back to the built-in probe.</summary>
        private readonly Func<IReadOnlyList<NetworkTopologyPanel.TopoNode>> _liveScanProvider;
        private TextBox _txtVehicle;

        private readonly DiagnosticEngine _engine;
        private readonly Stores.FleetDistributionStore _fleet;
        private readonly Stores.FixedByOutcomeStore _fixedBy;
        private readonly SnapshotCaptureService _capture;

        private ListBox _lstProfiles;
        private RichTextBox _txtInstructions;
        private NumericUpDown _nudCyls;
        private TextBox _txtVin;
        private ComboBox _cmbAirMetering;
        private CheckBox _chkArmActive, _chkContributeFleet;
        private Button _btnCapture, _btnCancel, _btnMeasureBus;
        /// <summary>Technician-measured per-bus resistance (from the DLC), merged by bus.
        /// Attached to every snapshot so M3 folds real termination physics into its verdict.</summary>
        private readonly List<BusHealth> _measuredBusHealth = new List<BusHealth>();
        /// <summary>The last captured snapshot, so a bus measurement can re-analyze it in place.</summary>
        private DiagnosticSnapshot _lastSnap;
        private FlowLayoutPanel _findings;
        private Label _lblFindingsHeader;
        private Panel _detailHost;
        private Label _lblHypothesis, _lblAdvisory, _lblNextTest, _lblSuspects, _counter;
        private EvidenceChainRenderer _renderer;
        private Button _btnRunConfirm, _btnCopy;
        private RichTextBox _log;
        private Label _lblSkipped;

        private Thread _worker;
        private volatile bool _running;
        private FindingCard _selectedCard;
        private DiagnosticResult _selectedResult;

        private static readonly byte[] CapturePidsDefault =
            { 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0B, 0x0C, 0x0E, 0x0F, 0x10, 0x11, 0x33, 0x42, 0x5C };

        public DiagnosticIntelligenceDialog(J2534Manager j2534, UDSManager uds, OBDonUDSManager obd,
                                            string detectedVin = null,
                                            Func<IReadOnlyList<NetworkTopologyPanel.TopoNode>> liveScanProvider = null)
        {
            _j2534 = j2534;
            _uds = uds;
            _obd = obd;
            _detectedVin = detectedVin;
            _liveScanProvider = liveScanProvider;

            IntelligenceBootstrap.EnsureRegistered();
            _fleet = new Stores.FleetDistributionStore();
            _fixedBy = new Stores.FixedByOutcomeStore();
            _engine = new DiagnosticEngine { Fleet = _fleet, FixedBy = _fixedBy, Log = AppendLogSafe };
            _engine.RegisterBuiltIns();
            _capture = new SnapshotCaptureService(_j2534, _uds, _obd);
            _capture.OnProgress += AppendLogSafe;

            Text = "Diagnostic Intelligence — Advanced Diagnostics";
            ClientSize = new Size(1380, 860);
            MinimumSize = new Size(1120, 680);
            DiTheme.ApplyChrome(this);
            BuildUi();
            FormClosing += (s, e) => { _running = false; try { _fleet.Flush(); _fixedBy.Flush(); } catch { } };
        }

        private void BuildUi()
        {
            var root = DiTheme.MakeRoot();
            root.Controls.Add(DiTheme.MakeBanner(
                "Diagnostic Intelligence Workbench",
                "Guided capture → signal-inversion + model-based fault isolation → evidence, confidence, and the next test to run",
                out _counter), 0, 0);

            var body = new TableLayoutPanel
            {
                Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 2,
                BackColor = DiTheme.BG_DARK, Padding = new Padding(10),
            };
            body.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            body.RowStyles.Add(new RowStyle(SizeType.Absolute, 128));
            root.Controls.Add(body, 0, 1);

            // ── content: profiles | findings | detail ──
            var content = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 3, RowCount = 1, BackColor = DiTheme.BG_DARK };
            content.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 336));
            content.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 430));
            content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            body.Controls.Add(content, 0, 0);

            content.Controls.Add(BuildProfilePanel(), 0, 0);
            content.Controls.Add(BuildFindingsPanel(), 1, 0);
            content.Controls.Add(BuildDetailPanel(), 2, 0);

            // ── log + skipped ──
            var logPanel = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 1, BackColor = DiTheme.BG_DARK };
            logPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62));
            logPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38));
            _log = new RichTextBox { Dock = DockStyle.Fill, ReadOnly = true, BackColor = DiTheme.BG_DETAIL, ForeColor = DiTheme.FG_PRIMARY, Font = DiTheme.MonoSmall, BorderStyle = BorderStyle.FixedSingle };
            _lblSkipped = new Label { Dock = DockStyle.Fill, Font = DiTheme.UiSmall, ForeColor = DiTheme.FG_DIM, AutoSize = false, BackColor = DiTheme.BG_PANEL, Padding = new Padding(8, 6, 6, 6) };
            logPanel.Controls.Add(_log, 0, 0);
            logPanel.Controls.Add(_lblSkipped, 1, 0);
            body.Controls.Add(logPanel, 0, 1);

            // Parent the whole layout onto the form — without this the form has no
            // content and renders as a blank client area.
            Controls.Add(root);

            // Select the default profile.
            if (_lstProfiles.Items.Count > 0)
            {
                int di = CaptureProfileCatalog.All.ToList().FindIndex(p => p.Id == CaptureProfileCatalog.Default.Id);
                _lstProfiles.SelectedIndex = di < 0 ? 0 : di;
            }
        }

        private Control BuildProfilePanel()
        {
            var tl = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 5, BackColor = DiTheme.BG_PANEL, Padding = new Padding(8) };
            tl.RowStyles.Add(new RowStyle(SizeType.Absolute, 22));
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 42));
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 58));
            tl.RowStyles.Add(new RowStyle(SizeType.Absolute, 168));
            tl.RowStyles.Add(new RowStyle(SizeType.Absolute, 80));

            tl.Controls.Add(SectionLabel("CAPTURE PROFILE"), 0, 0);

            _lstProfiles = new ListBox { Dock = DockStyle.Fill, BackColor = DiTheme.BG_INPUT, ForeColor = DiTheme.FG_PRIMARY, Font = DiTheme.UiBold, BorderStyle = BorderStyle.FixedSingle, IntegralHeight = false };
            foreach (var p in CaptureProfileCatalog.All) _lstProfiles.Items.Add(p);
            _lstProfiles.SelectedIndexChanged += (s, e) => ShowProfileInstructions();
            tl.Controls.Add(_lstProfiles, 0, 1);

            _txtInstructions = new RichTextBox { Dock = DockStyle.Fill, ReadOnly = true, BackColor = DiTheme.BG_DETAIL, ForeColor = DiTheme.FG_SECOND, Font = DiTheme.UiFont, BorderStyle = BorderStyle.FixedSingle };
            tl.Controls.Add(_txtInstructions, 0, 2);

            // controls (cyl, air metering, vin, vehicle, options)
            var ctl = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 5, BackColor = DiTheme.BG_PANEL };
            ctl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92));
            ctl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            ctl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28)); // cylinders
            ctl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28)); // air metering
            ctl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28)); // VIN
            ctl.RowStyles.Add(new RowStyle(SizeType.Absolute, 28)); // vehicle (model / engine)
            ctl.RowStyles.Add(new RowStyle(SizeType.Absolute, 48)); // options (stacked checks)

            ctl.Controls.Add(FieldLabel("Cylinders"), 0, 0);
            _nudCyls = new NumericUpDown { Minimum = 1, Maximum = 16, Value = 4, Width = 60, Anchor = AnchorStyles.Left, BackColor = DiTheme.BG_INPUT, ForeColor = DiTheme.FG_PRIMARY, BorderStyle = BorderStyle.FixedSingle };
            ctl.Controls.Add(_nudCyls, 1, 0);

            // Air-metering configuration — decisive for T2/T3: a speed-density engine
            // has NO MAF, so the MAF-vs-speed-density cross-check must be suppressed.
            ctl.Controls.Add(FieldLabel("Air metering"), 0, 1);
            _cmbAirMetering = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList, Font = DiTheme.UiFont, FlatStyle = FlatStyle.Flat, BackColor = DiTheme.BG_INPUT, ForeColor = DiTheme.FG_PRIMARY, Margin = new Padding(0, 2, 0, 2) };
            _cmbAirMetering.Items.AddRange(new object[]
            {
                new MeteringChoice("Auto-detect from PIDs", AirMeteringKind.AutoDetect),
                new MeteringChoice("MAF only (mass airflow)", AirMeteringKind.MafOnly),
                new MeteringChoice("Speed-density (MAP, no MAF)", AirMeteringKind.SpeedDensityMap),
                new MeteringChoice("MAF + MAP (both sensors)", AirMeteringKind.MafAndMap),
                new MeteringChoice("TMAP (temp+MAP, no MAF)", AirMeteringKind.Tmap),
            });
            _cmbAirMetering.SelectedIndex = 0;
            ctl.Controls.Add(_cmbAirMetering, 1, 1);

            ctl.Controls.Add(FieldLabel("VIN"), 0, 2);
            _txtVin = new TextBox { Dock = DockStyle.Fill, Font = DiTheme.Mono, BackColor = DiTheme.BG_INPUT, ForeColor = DiTheme.FG_PRIMARY, BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(0, 2, 0, 2) };
            // Auto-populate from the VIN already read off the vehicle (if any); the
            // technician can still overtype it for a manual/what-if platform.
            if (!string.IsNullOrWhiteSpace(_detectedVin)) _txtVin.Text = _detectedVin.Trim();
            _txtVin.Leave += (s, e) => PrefillVehicleFromVin();
            ctl.Controls.Add(_txtVin, 1, 2);

            // Technician-selected vehicle (model / engine) — the identity that keys the
            // per-vehicle topology / calibration.  Defaults from the VIN decode; editable.
            ctl.Controls.Add(FieldLabel("Vehicle"), 0, 3);
            _txtVehicle = new TextBox { Dock = DockStyle.Fill, Font = DiTheme.UiFont, BackColor = DiTheme.BG_INPUT, ForeColor = DiTheme.FG_PRIMARY, BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(0, 2, 0, 2) };
            _txtVehicle.Text = DescribeVinVehicle(_detectedVin);
            ctl.Controls.Add(_txtVehicle, 1, 3);

            var checks = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, WrapContents = false, BackColor = DiTheme.BG_PANEL };
            _chkArmActive = new CheckBox { Text = "Arm active-control confirmation tests", AutoSize = true, ForeColor = DiTheme.ACCENT_AMB };
            _chkContributeFleet = new CheckBox { Text = "Contribute to fleet baseline", AutoSize = true, Checked = true, ForeColor = DiTheme.FG_SECOND };
            checks.Controls.Add(_chkArmActive);
            checks.Controls.Add(_chkContributeFleet);
            ctl.Controls.Add(FieldLabel("Options"), 0, 4);
            ctl.Controls.Add(checks, 1, 4);
            tl.Controls.Add(ctl, 0, 3);

            // capture / measure / cancel buttons
            var btnRow = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 2, BackColor = DiTheme.BG_PANEL };
            btnRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65));
            btnRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));
            btnRow.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            btnRow.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            _btnCapture = new Button { Text = "Capture && Analyze", Dock = DockStyle.Fill, Font = DiTheme.UiBold, BackColor = DiTheme.ACCENT_BLUE, ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            _btnCapture.Click += (s, e) => StartCapture();
            _btnMeasureBus = new Button { Text = "Measure Bus Ω…", Dock = DockStyle.Fill, FlatStyle = FlatStyle.Flat, BackColor = DiTheme.BG_PANEL2, ForeColor = DiTheme.FG_PRIMARY };
            _btnMeasureBus.Click += (s, e) => MeasureBusResistance();
            _btnCancel = new Button { Text = "Stop", Dock = DockStyle.Fill, Enabled = false, FlatStyle = FlatStyle.Flat };
            _btnCancel.Click += (s, e) => { _running = false; AppendLogSafe("Cancelling…"); };
            btnRow.Controls.Add(_btnCapture, 0, 0);
            btnRow.SetColumnSpan(_btnCapture, 2);
            btnRow.Controls.Add(_btnMeasureBus, 0, 1);
            btnRow.Controls.Add(_btnCancel, 1, 1);
            tl.Controls.Add(btnRow, 0, 4);

            return tl;
        }

        private Control BuildFindingsPanel()
        {
            var tl = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 2, BackColor = DiTheme.BG_PANEL, Padding = new Padding(8) };
            tl.RowStyles.Add(new RowStyle(SizeType.Absolute, 22));
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            _lblFindingsHeader = SectionLabel("FINDINGS");
            tl.Controls.Add(_lblFindingsHeader, 0, 0);
            _findings = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, WrapContents = false, AutoScroll = true, BackColor = DiTheme.BG_PANEL };
            _findings.Resize += (s, e) => ResizeFindingCards();
            tl.Controls.Add(_findings, 0, 1);
            return tl;
        }

        private Control BuildDetailPanel()
        {
            _detailHost = new Panel { Dock = DockStyle.Fill, AutoScroll = true, BackColor = DiTheme.BG_PANEL, Padding = new Padding(12) };

            _btnCopy = new Button { Text = "Copy", Dock = DockStyle.Top, Height = 26, FlatStyle = FlatStyle.Flat, Visible = false };
            _btnCopy.Click += (s, e) => CopySelectedDetail();
            _btnRunConfirm = new Button { Text = "Run Confirmation Test…", Dock = DockStyle.Top, Height = 38, Font = DiTheme.UiBold, FlatStyle = FlatStyle.Flat, BackColor = DiTheme.ACCENT_TEAL, ForeColor = Color.White, Visible = false };
            _btnRunConfirm.Click += (s, e) => StartConfirmation();
            _lblSuspects = new Label { Dock = DockStyle.Top, Font = DiTheme.UiFont, ForeColor = DiTheme.FG_SECOND, AutoSize = false, Height = 48 };
            _lblNextTest = new Label { Dock = DockStyle.Top, Font = DiTheme.UiBold, ForeColor = DiTheme.ACCENT_BLUE, AutoSize = false, Height = 84 };
            _renderer = new EvidenceChainRenderer { Dock = DockStyle.Top, HeaderText = "Evidence", Height = 220, BackColor = DiTheme.BG_PANEL };
            _lblAdvisory = new Label { Dock = DockStyle.Top, Font = DiTheme.UiSmallBold, ForeColor = DiTheme.ACCENT_AMB, AutoSize = false, Height = 34 };
            _lblHypothesis = new Label { Dock = DockStyle.Top, Font = DiTheme.Title, ForeColor = DiTheme.FG_PRIMARY, AutoSize = false, Height = 56 };

            // Dock=Top stacks last-added on top → add bottom-most first.
            _detailHost.Controls.Add(_btnCopy);
            _detailHost.Controls.Add(_btnRunConfirm);
            _detailHost.Controls.Add(_lblSuspects);
            _detailHost.Controls.Add(_lblNextTest);
            _detailHost.Controls.Add(_renderer);
            _detailHost.Controls.Add(_lblAdvisory);
            _detailHost.Controls.Add(_lblHypothesis);
            return _detailHost;
        }

        // ── profile instructions ────────────────────────────────────────────
        private void ShowProfileInstructions()
        {
            var p = _lstProfiles.SelectedItem as CaptureProfile;
            if (p == null) { _txtInstructions.Clear(); return; }
            _txtInstructions.Clear();
            _txtInstructions.SelectionFont = DiTheme.UiBold;
            _txtInstructions.SelectionColor = DiTheme.FG_PRIMARY;
            _txtInstructions.AppendText(p.Name + (p.DurationSeconds > 0 ? $"  ({p.DurationSeconds}s)\n" : "\n"));
            _txtInstructions.SelectionFont = DiTheme.UiFont;
            _txtInstructions.SelectionColor = DiTheme.FG_SECOND;
            _txtInstructions.AppendText("\n" + p.Instructions + "\n\n");
            _txtInstructions.SelectionColor = DiTheme.FG_DIM;
            _txtInstructions.AppendText("Modules: " + string.Join(", ", p.OrientedModules ?? new string[0]));
        }

        // ── capture + analyze ───────────────────────────────────────────────
        private void StartCapture()
        {
            if (_running) return;
            if (_j2534 == null || !_j2534.IsConnected)
            {
                MessageBox.Show(this, "Connect to a vehicle first.", "Diagnostic Intelligence", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var profile = _lstProfiles.SelectedItem as CaptureProfile ?? CaptureProfileCatalog.Default;

            _running = true;
            _btnCapture.Enabled = false;
            _btnCancel.Enabled = true;
            ClearFindings();
            ClearDetail();
            AppendLogSafe($"=== {profile.Name} ===");

            int cyls = (int)_nudCyls.Value;
            string vin = _txtVin.Text?.Trim() ?? "";
            string vehicle = _txtVehicle?.Text?.Trim() ?? "";
            AirMeteringKind metering = SelectedMetering();
            bool arm = _chkArmActive.Checked;
            bool contribute = _chkContributeFleet.Checked;

            // Pull the CAN Topographer's last scan on the UI thread (it owns that state), so
            // capture reuses the real per-VIN CAN map instead of the built-in fallback probe.
            IReadOnlyList<NetworkTopologyPanel.TopoNode> liveNodes = null;
            try { liveNodes = _liveScanProvider?.Invoke(); } catch { }
            if (liveNodes != null && liveNodes.Count > 0)
                AppendLogSafe($"CAN Topographer map available — {liveNodes.Count} module(s) from the last scan.");
            else if (profile.Kind == CaptureKind.NetworkScan)
                AppendLogSafe("No CAN Topographer scan found — run a Network Topology scan first for a full per-VIN map; falling back to the built-in module probe.");

            _worker = new Thread(() => CaptureWorker(profile, cyls, vin, vehicle, metering, arm, contribute, liveNodes)) { IsBackground = true, Name = "DiagIntelCapture" };
            _worker.Start();
        }

        private void CaptureWorker(CaptureProfile profile, int cyls, string vin, string vehicle,
                                   AirMeteringKind metering, bool arm, bool contribute,
                                   IReadOnlyList<NetworkTopologyPanel.TopoNode> liveNodes)
        {
            try
            {
                var snap = _capture.Capture(profile, cyls, vin, metering, () => !_running, liveNodes, vehicle, null);
                AttachMeasuredBusHealth(snap);   // fold in any DLC resistance already measured this session
                _lastSnap = snap;
                _engine.AllowActiveControl = arm;
                var run = _engine.Run(snap);
                if (contribute) LearnFleet(snap);
                BeginInvoke((Action)(() => ShowResults(run, snap)));
            }
            catch (Exception ex)
            {
                AppendLogSafe("Analyze error: " + ex.Message);
            }
            finally
            {
                _running = false;
                try { BeginInvoke((Action)(() => { _btnCapture.Enabled = true; _btnCancel.Enabled = false; })); } catch { }
            }
        }

        private void ShowResults(DiagnosticRunResult run, DiagnosticSnapshot snap)
        {
            ClearFindings();
            if (run == null) return;

            _lblFindingsHeader.Text = $"FINDINGS ({run.FindingCount})";
            foreach (var r in run.Results)
            {
                var card = new FindingCard(r);
                card.Click += (s, e) => SelectCard(card);
                _findings.Controls.Add(card);
            }
            ResizeFindingCards();

            _lblSkipped.Text = (run.Skipped != null && run.Skipped.Count > 0)
                ? "Not run:\n" + string.Join("\n", run.Skipped.Select(s => $"  {s.ModuleId}: {s.Reason}"))
                : "All applicable modules ran.";

            AppendLogSafe($"Analysis complete — {run.FindingCount} finding(s) via {(run.Calibration != null ? run.Calibration.DisplayName : "no calibration")}.");
            if (run.AnyFindings) SelectCard(_findings.Controls[0] as FindingCard);
            else ClearDetail();
        }

        private void SelectCard(FindingCard card)
        {
            if (card == null) return;
            if (_selectedCard != null) _selectedCard.Selected = false;
            _selectedCard = card;
            _selectedCard.Selected = true;
            _selectedResult = card.Result;
            ShowSelectedDetail();
        }

        private void ShowSelectedDetail()
        {
            var r = _selectedResult;
            if (r == null) { ClearDetail(); return; }

            _lblHypothesis.Text = $"[{r.ModuleId}] {r.Hypothesis}";
            _lblAdvisory.Text = r.Advisory ? "⚠ Advisory — " + (r.AdvisoryReason ?? "spec-seeded thresholds, not validated on this vehicle") : "";
            _renderer.Chain = r.Evidence;
            _renderer.Height = Math.Max(120, (r.Evidence?.Count ?? 0) * 46 + 44);
            _lblNextTest.Text = "NEXT TEST\n" + (r.NextTest ?? "—");
            _lblSuspects.Text = (r.SuspectComponents != null && r.SuspectComponents.Count > 0)
                ? "Suspect components: " + string.Join(", ", r.SuspectComponents) : "";

            bool hasScript = r.NextTestScript != null && r.NextTestScript.Steps != null && r.NextTestScript.Steps.Count > 0;
            _btnRunConfirm.Visible = hasScript;
            _btnRunConfirm.Text = hasScript
                ? (r.NextTestScript.RequiresActiveControl ? "Run Confirmation Test… (active control)" : "Run Confirmation Test…")
                : "Run Confirmation Test…";
            _btnCopy.Visible = true;
        }

        private void ClearDetail()
        {
            _lblHypothesis.Text = "";
            _lblAdvisory.Text = "";
            if (_renderer != null) _renderer.Chain = null;
            _lblNextTest.Text = "";
            _lblSuspects.Text = "";
            if (_btnRunConfirm != null) _btnRunConfirm.Visible = false;
            if (_btnCopy != null) _btnCopy.Visible = false;
            _selectedResult = null;
        }

        private void ClearFindings()
        {
            if (_selectedCard != null) _selectedCard.Selected = false;
            _selectedCard = null;
            foreach (Control c in _findings.Controls.OfType<Control>().ToList()) { c.Dispose(); }
            _findings.Controls.Clear();
            _lblFindingsHeader.Text = "FINDINGS";
        }

        private void ResizeFindingCards()
        {
            int w = _findings.ClientSize.Width - 8;
            if (w < 80) return;
            foreach (Control c in _findings.Controls) c.Width = w;
        }

        // ── confirmation ────────────────────────────────────────────────────
        private void StartConfirmation()
        {
            var r = _selectedResult;
            if (r?.NextTestScript == null || _running) return;
            if (_uds == null) { MessageBox.Show(this, "UDS transport not available.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            bool armed = _chkArmActive.Checked;
            if (r.NextTestScript.RequiresActiveControl && !armed)
            {
                var ans = MessageBox.Show(this,
                    "This confirmation sequence commands the ECU. 'Arm active-control confirmation tests' is not " +
                    "checked, so active steps will be SKIPPED (observe-only steps still run).\n\nContinue with observe-only?",
                    "Active control not armed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (ans != DialogResult.OK) return;
            }

            _running = true;
            _btnRunConfirm.Enabled = false;
            AppendLogSafe($"--- Confirmation: {r.NextTestScript.Name} ---");
            var worker = new Thread(() => ConfirmationWorker(r.NextTestScript, armed)) { IsBackground = true, Name = "DiagIntelConfirm" };
            worker.Start();
        }

        private void ConfirmationWorker(ConfirmationScript script, bool armed)
        {
            try
            {
                var runner = new ConfirmationRunner(_uds);
                runner.Run(script, armed, ConfirmActiveOnUi, AppendLogSafe);
                AppendLogSafe("--- Confirmation complete ---");
            }
            catch (Exception ex)
            {
                AppendLogSafe("Confirmation error: " + ex.Message);
            }
            finally
            {
                _running = false;
                try { BeginInvoke((Action)(() => _btnRunConfirm.Enabled = true)); } catch { }
            }
        }

        private bool ConfirmActiveOnUi(ConfirmActiveRequest req)
        {
            try
            {
                return (bool)Invoke(new Func<bool>(() =>
                    MessageBox.Show(this, req.WarningText, "Confirm active-control command",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes));
            }
            catch { return false; }
        }

        // ── bus-resistance measurement (physical evidence for M3) ───────────────
        private void MeasureBusResistance()
        {
            try
            {
                // Always offer both buses — a key-off resistance probe is harmless, and the
                // technician knows the vehicle better than a VIN heuristic (pins 3/11 are the
                // Ford MS-CAN convention but other platforms use a second bus there too; an OL
                // reading is itself informative). Don't lock the tech out of a measurement.
                using (var dlg = new BusResistanceDialog(showMsCan: true))
                {
                    if (dlg.ShowDialog(this) != DialogResult.OK || dlg.Results.Count == 0) return;
                    foreach (var bh in dlg.Results) MergeMeasuredBus(bh);
                    AppendLogSafe("Bus resistance recorded: " + string.Join("; ",
                        dlg.Results.Select(b => $"{b.Bus} {BusResistance.Fmt(b.MeasuredResistanceOhms ?? 0)} Ohm ({b.State})")));
                    if (_lastSnap != null && !_running) ReanalyzeWithBusHealth();
                    else AppendLogSafe("Recorded — it will be folded into the next capture.");
                }
            }
            catch (Exception ex) { AppendLogSafe("Bus resistance error: " + ex.Message); }
        }

        /// <summary>Store a measured bus reading, replacing any prior reading for that bus.</summary>
        private void MergeMeasuredBus(BusHealth bh)
        {
            if (bh == null) return;
            lock (_measuredBusHealth)
            {
                _measuredBusHealth.RemoveAll(x => x.Bus == bh.Bus);
                _measuredBusHealth.Add(bh);
            }
        }

        /// <summary>Copy the session's measured bus readings onto a snapshot (merged by bus).</summary>
        private void AttachMeasuredBusHealth(DiagnosticSnapshot snap)
        {
            if (snap == null) return;
            lock (_measuredBusHealth)
                foreach (var bh in _measuredBusHealth)
                    snap.AddBusHealth(new BusHealth
                    {
                        Bus = bh.Bus, ExpectedTerminators = bh.ExpectedTerminators,
                        MeasuredResistanceOhms = bh.MeasuredResistanceOhms, State = bh.State,
                        Verdict = bh.Verdict, ProbableFaultMode = bh.ProbableFaultMode,
                    });
        }

        /// <summary>Re-run the engine over the last capture with the new resistance evidence.</summary>
        private void ReanalyzeWithBusHealth()
        {
            if (_lastSnap == null) return;
            AttachMeasuredBusHealth(_lastSnap);
            var run = _engine.Run(_lastSnap);
            ShowResults(run, _lastSnap);
            AppendLogSafe("Re-analyzed with the measured bus resistance.");
        }

        // ── fleet learning (host responsibility, kept out of the pure modules) ──
        private void LearnFleet(DiagnosticSnapshot snap)
        {
            try
            {
                var grid = new OperatingPointGrid(6, 6, 500, 6500, 0, 100);
                double rpm = snap.Latest(CanonicalSignals.Rpm, double.NaN);
                double load = snap.Latest(CanonicalSignals.EngineLoad, double.NaN);
                if (double.IsNaN(rpm) || double.IsNaN(load)) return;
                var (cx, cy) = grid.CellOf(rpm, load);
                foreach (var kv in snap.Signals)
                {
                    var sser = kv.Value;
                    if (sser == null || !sser.HasData) continue;
                    _fleet.Record(snap.Platform, kv.Key, cx, cy, sser.Latest);
                }
                _fleet.Flush();
                AppendLogSafe("Fleet baseline updated for platform " + snap.Platform + ".");
            }
            catch { }
        }

        // ── helpers ─────────────────────────────────────────────────────────
        private void CopySelectedDetail()
        {
            var r = _selectedResult;
            if (r == null) return;
            try
            {
                var sb = new System.Text.StringBuilder();
                sb.AppendLine($"[{r.ModuleId}] {r.Hypothesis}  ({r.ConfidencePercent}% {r.ConfidenceBand}{(r.Advisory ? ", advisory" : "")})");
                if (r.Advisory && !string.IsNullOrEmpty(r.AdvisoryReason)) sb.AppendLine("Advisory: " + r.AdvisoryReason);
                sb.AppendLine();
                sb.AppendLine("Evidence:");
                sb.AppendLine(r.Evidence?.Render() ?? "(none)");
                sb.AppendLine();
                sb.AppendLine("Next test: " + (r.NextTest ?? "—"));
                if (r.SuspectComponents != null && r.SuspectComponents.Count > 0)
                    sb.AppendLine("Suspects: " + string.Join(", ", r.SuspectComponents));
                Clipboard.SetText(sb.ToString());
                AppendLogSafe("Finding copied to clipboard.");
            }
            catch (Exception ex) { AppendLogSafe("Copy failed: " + ex.Message); }
        }

        private static Label SectionLabel(string text) => new Label
        {
            Text = text, Dock = DockStyle.Fill, Font = DiTheme.UiSmallBold,
            ForeColor = DiTheme.ACCENT_BLUE, TextAlign = ContentAlignment.MiddleLeft,
        };

        private static Label FieldLabel(string text) => new Label
        {
            Text = text, Dock = DockStyle.Fill, Font = DiTheme.UiFont,
            ForeColor = DiTheme.FG_SECOND, TextAlign = ContentAlignment.MiddleLeft,
        };

        /// <summary>The technician's declared air-metering configuration (or AutoDetect).</summary>
        private AirMeteringKind SelectedMetering()
            => (_cmbAirMetering?.SelectedItem as MeteringChoice)?.Kind ?? AirMeteringKind.AutoDetect;

        /// <summary>Prefill the Vehicle field from the current VIN when the tech hasn't typed one.</summary>
        private void PrefillVehicleFromVin()
        {
            try
            {
                if (_txtVehicle == null || !string.IsNullOrWhiteSpace(_txtVehicle.Text)) return;
                _txtVehicle.Text = DescribeVinVehicle(_txtVin?.Text);
            }
            catch { }
        }

        /// <summary>Best-effort "Manufacturer ModelYear" label from a VIN, for the editable
        /// Vehicle field — the technician confirms/refines it (make/model/engine).</summary>
        private static string DescribeVinVehicle(string vin)
        {
            if (string.IsNullOrWhiteSpace(vin)) return "";
            try
            {
                var d = VINDecoder.Decode(vin.Trim());
                if (d == null) return "";
                string mfr = !string.IsNullOrWhiteSpace(d.Manufacturer) ? d.Manufacturer : "";
                string yr = d.ModelYear > 0 ? d.ModelYear.ToString() : "";
                return string.Join(" ", new[] { yr, mfr }.Where(s => !string.IsNullOrWhiteSpace(s))).Trim();
            }
            catch { return ""; }
        }

        /// <summary>Combo item pairing a human label with an <see cref="AirMeteringKind"/>.</summary>
        private sealed class MeteringChoice
        {
            public string Label { get; }
            public AirMeteringKind Kind { get; }
            public MeteringChoice(string label, AirMeteringKind kind) { Label = label; Kind = kind; }
            public override string ToString() => Label;
        }

        private void AppendLogSafe(string msg)
        {
            if (_log == null) return;
            try
            {
                if (_log.InvokeRequired) { _log.BeginInvoke((Action)(() => AppendLogSafe(msg))); return; }
                _log.AppendText($"[{DateTime.Now:HH:mm:ss}] {msg}\n");
                _log.SelectionStart = _log.TextLength;
                _log.ScrollToCaret();
            }
            catch { }
        }
    }
}
