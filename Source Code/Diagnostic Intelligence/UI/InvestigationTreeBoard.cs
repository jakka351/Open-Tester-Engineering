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
//  Tester Present Specialist Automotive Solutions — Investigation Tree Board (U2)
//
//  The centrepiece: a custom-painted node graph that renders the live investigation
//  as the mechanic's own mental model — CONNECT is the root, observations fan the
//  first branches, hypotheses are competing branches, tests are gated edges, and
//  FAILURE is a first-class node that greys out but is NEVER deleted, so the ruled-out
//  branches ARE the map of where you've been.
//
//  Layout is a simple left→right layered DAG keyed on NodeKind (root · observation ·
//  hypothesis · test · outcome · fix).  Within the hypothesis column, Live theories
//  sit on top ordered by belief; suspended below; ruled-out at the bottom, greyed.
//  Edges are drawn from the session's Edge list, coloured by kind and by the SIGN of
//  the log-odds delta (a support edge is green, a refutation red).  The board is a
//  pure projection — it holds no belief math; it reads the session and paints it.
//
//  Thread-safety: the board paints on the UI thread but the session can be mutated by
//  a background (MCP) thread, so SetSession/Refresh SNAPSHOT the node/edge lists into
//  private copies (the caller holds the DI lock during the snapshot); paint + layout
//  enumerate only those copies, never the live session — no "Collection was modified".
//  Text is drawn with g.DrawString (GDI+), which honours the AutoScroll world transform;
//  TextRenderer (GDI) ignores it and would detach labels from their boxes when scrolled.
// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using TesterPresent.OBD2.Intelligence.Session;
using Theme = TesterPresent.OBD2.UI.TesTheme;

namespace TesterPresent.OBD2.Intelligence.UI
{
    /// <summary>Custom-painted board that renders a <see cref="DiagnosticSession"/> as a layered node graph.
    /// Derives from Panel (a ScrollableControl) so AutoScroll works for graphs larger than the viewport.</summary>
    public sealed class InvestigationTreeBoard : Panel
    {
        // Private SNAPSHOT of the session graph — paint/layout read these, never the live session.
        private List<ReasoningNode> _nodes = new List<ReasoningNode>();
        private List<Edge> _edges = new List<Edge>();
        private Dictionary<Guid, ReasoningNode> _nodeById = new Dictionary<Guid, ReasoningNode>();
        private readonly Dictionary<Guid, RectangleF> _rects = new Dictionary<Guid, RectangleF>();
        private Guid _selected;

        /// <summary>Raised when the tech clicks a node — the workbench shows its detail.</summary>
        public event Action<ReasoningNode> SelectedNodeChanged;

        // Layout geometry
        private const int NODE_W = 178;
        private const int H_DEFAULT = 44;
        private const int H_HYP = 54;
        private const int COL_GAP = 66;
        private const int ROW_GAP = 14;
        private const int MARGIN = 26;

        // Reusable string formats (GDI+ text honours the world transform; process-lifetime, never disposed).
        private static readonly StringFormat FmtLeftEllipsis = new StringFormat(StringFormatFlags.NoWrap)
            { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near, Trimming = StringTrimming.EllipsisWord };
        private static readonly StringFormat FmtLeft = new StringFormat(StringFormatFlags.NoWrap)
            { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near, Trimming = StringTrimming.EllipsisCharacter };
        private static readonly StringFormat FmtRight = new StringFormat(StringFormatFlags.NoWrap)
            { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Near };
        private static readonly StringFormat FmtCenter = new StringFormat
            { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

        public InvestigationTreeBoard()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint
                     | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            BackColor = Theme.BgCard;
            AutoScroll = true;
            Font = Theme.Ui(9f);
        }

        public void SetSession(DiagnosticSession session)
        {
            Snapshot(session);
            _selected = Guid.Empty;
            Relayout();
            Invalidate();
        }

        /// <summary>Re-read the session (belief/status may have changed) and repaint.</summary>
        public void Refresh(DiagnosticSession session)
        {
            Snapshot(session);
            Relayout();
            Invalidate();
        }

        /// <summary>Copy the node/edge LISTS (node references shared, list structure private) so paint
        /// and layout never enumerate a live session list a background thread may be mutating. The
        /// caller holds the DI lock during this call, so the ToList() itself can't race a mutation.</summary>
        private void Snapshot(DiagnosticSession session)
        {
            _nodes = session?.Nodes?.ToList() ?? new List<ReasoningNode>();
            _edges = session?.Edges?.ToList() ?? new List<Edge>();
            _nodeById = new Dictionary<Guid, ReasoningNode>();
            foreach (var n in _nodes) _nodeById[n.Id] = n;
        }

        // ── Layout ────────────────────────────────────────────────────────────────

        private static int Tier(NodeKind k)
        {
            switch (k)
            {
                case NodeKind.Root: return 0;
                case NodeKind.Observation: return 1;
                case NodeKind.Hypothesis: return 2;
                case NodeKind.Test: return 3;
                case NodeKind.Outcome: return 4;
                default: return 5; // Fix
            }
        }

        private static int NodeHeight(ReasoningNode n) => n.Kind == NodeKind.Hypothesis ? H_HYP : H_DEFAULT;

        private void Relayout()
        {
            _rects.Clear();
            if (_nodes.Count == 0) { AutoScrollMinSize = Size.Empty; return; }

            var tiers = new Dictionary<int, List<ReasoningNode>>();
            foreach (var n in _nodes)
            {
                int t = Tier(n.Kind);
                if (!tiers.TryGetValue(t, out var list)) { list = new List<ReasoningNode>(); tiers[t] = list; }
                list.Add(n);
            }

            float maxX = 0, maxY = 0;
            foreach (var kv in tiers.OrderBy(k => k.Key))
            {
                var list = kv.Value;
                if (kv.Key == Tier(NodeKind.Hypothesis)) list = OrderHypotheses(list);
                else list = list.OrderBy(n => n.CreatedUtc).ToList();

                float x = MARGIN + kv.Key * (NODE_W + COL_GAP);
                float y = MARGIN;
                foreach (var n in list)
                {
                    float h = NodeHeight(n);
                    _rects[n.Id] = new RectangleF(x, y, NODE_W, h);
                    y += h + ROW_GAP;
                    maxX = Math.Max(maxX, x + NODE_W);
                    maxY = Math.Max(maxY, y);
                }
            }
            AutoScrollMinSize = new Size((int)(maxX + MARGIN), (int)(maxY + MARGIN));
        }

        // Live (by belief) on top → suspended → refuted → pruned at the bottom.
        private static List<ReasoningNode> OrderHypotheses(List<ReasoningNode> hyps)
        {
            int Rank(NodeStatus s)
            {
                switch (s)
                {
                    case NodeStatus.BestSupported: return 0;
                    case NodeStatus.Live: return 1;
                    case NodeStatus.Suspended: return 2;
                    case NodeStatus.Refuted: return 3;
                    default: return 4; // Pruned
                }
            }
            return hyps.OrderBy(n => Rank(n.Status))
                       .ThenByDescending(n => n.EffectivePosterior)
                       .ToList();
        }

        // ── Paint ─────────────────────────────────────────────────────────────────

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            if (_rects.Count == 0)
            {
                Str(g, "Capture & Analyze to grow the investigation tree.", Theme.Ui(9.5f), Theme.TextDim,
                    new RectangleF(0, 0, Width, Height), FmtCenter);
                return;
            }

            g.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);
            foreach (var edge in _edges) DrawEdge(g, edge);
            foreach (var kv in _rects)
                if (_nodeById.TryGetValue(kv.Key, out var n)) DrawNode(g, n, kv.Value);
        }

        private void DrawEdge(Graphics g, Edge edge)
        {
            if (!_rects.TryGetValue(edge.FromId, out var a) || !_rects.TryGetValue(edge.ToId, out var b)) return;

            // Connect right-mid of the source to left-mid of the target with a smooth S-curve.
            var p1 = new PointF(a.Right, a.Top + a.Height / 2f);
            var p2 = new PointF(b.Left, b.Top + b.Height / 2f);
            float dx = Math.Max(24f, (p2.X - p1.X) * 0.5f);

            Color c; float w = 1.6f; bool dash = false;
            switch (edge.Kind)
            {
                case EdgeKind.Discriminates: c = Theme.Info; dash = true; break;
                case EdgeKind.Supports:
                    c = edge.LogOddsDelta >= 0 ? Theme.Good : Theme.Bad;
                    w = 2.0f + (float)Math.Min(2.0, Math.Abs(edge.LogOddsDelta));
                    break;
                case EdgeKind.Fixes: c = Theme.Accent; w = 2.2f; break;
                default: c = Theme.Border; break; // Establishes / Ruled
            }

            using (var pen = new Pen(c, w))
            {
                if (dash) pen.DashStyle = DashStyle.Dash;
                using (var path = new GraphicsPath())
                {
                    path.AddBezier(p1, new PointF(p1.X + dx, p1.Y), new PointF(p2.X - dx, p2.Y), p2);
                    g.DrawPath(pen, path);
                }
            }

            // Annotate a support edge with its signed delta at the midpoint.
            if (edge.Kind == EdgeKind.Supports && Math.Abs(edge.LogOddsDelta) >= 0.05)
            {
                string txt = (edge.LogOddsDelta >= 0 ? "+" : "−") + Math.Abs(edge.LogOddsDelta).ToString("0.0");
                Str(g, txt, Theme.Mono(7.5f, FontStyle.Bold), c,
                    new RectangleF((p1.X + p2.X) / 2f - 10, (p1.Y + p2.Y) / 2f - 16, 60, 14), FmtLeft);
            }
        }

        private void DrawNode(Graphics g, ReasoningNode n, RectangleF r)
        {
            if (n == null) return;
            bool dead = n.Kind == NodeKind.Hypothesis && (n.Status == NodeStatus.Refuted || n.Status == NodeStatus.Pruned);
            var st = StyleFor(n, dead);
            bool selected = n.Id == _selected;

            using (var path = Round(r, 9))
            {
                using (var fill = new SolidBrush(st.Fill)) g.FillPath(fill, path);
                // left status stripe
                using (var clip = Round(new RectangleF(r.X, r.Y, 5, r.Height), 9))
                using (var sb = new SolidBrush(st.Stripe)) g.FillPath(sb, clip);
                using (var pen = new Pen(selected ? Theme.Accent : st.Border, selected ? 2.2f : 1.2f)) g.DrawPath(pen, path);
            }

            var textRect = new RectangleF(r.X + 12, r.Y + 6, r.Width - 18, r.Height - 12);

            // Kind eyebrow (tiny) for non-hypothesis nodes; band label for hypotheses.
            if (n.Kind == NodeKind.Hypothesis)
            {
                Str(g, n.Title, Theme.Ui(9f, dead ? FontStyle.Regular : FontStyle.Bold), st.Text,
                    new RectangleF(textRect.X, textRect.Y, textRect.Width, 30), FmtLeftEllipsis);
                string band = n.Status == NodeStatus.Live ? FaultBanding.Label(n.Band) : n.Status.ToString().ToLowerInvariant();
                Str(g, band, Theme.Mono(7.5f, FontStyle.Bold), st.Stripe,
                    new RectangleF(textRect.X, r.Bottom - 18, textRect.Width, 14), FmtLeft);
                if (n.ConfirmedOnVehicle)
                    Str(g, "✓ on-vehicle", Theme.Mono(7.5f, FontStyle.Bold), Theme.Good,
                        new RectangleF(textRect.X, r.Bottom - 18, textRect.Width, 14), FmtRight);
            }
            else
            {
                Str(g, KindLabel(n), Theme.Mono(7f, FontStyle.Bold), st.Stripe,
                    new RectangleF(textRect.X, textRect.Y, textRect.Width, 12), FmtLeft);
                Str(g, n.Title, Theme.Ui(8.5f), st.Text,
                    new RectangleF(textRect.X, textRect.Y + 13, textRect.Width, textRect.Height - 13), FmtLeftEllipsis);
            }
        }

        private static void Str(Graphics g, string text, Font font, Color color, RectangleF rect, StringFormat fmt)
        {
            if (string.IsNullOrEmpty(text)) return;
            using (var b = new SolidBrush(color)) g.DrawString(text, font, b, rect, fmt);
        }

        private struct NodeStyle { public Color Fill, Border, Stripe, Text; }

        private static NodeStyle StyleFor(ReasoningNode n, bool dead)
        {
            if (dead)
                return new NodeStyle { Fill = Theme.BgInset, Border = Theme.BorderSoft, Stripe = Theme.TextDim, Text = Theme.TextDim };

            switch (n.Kind)
            {
                case NodeKind.Root:
                    return new NodeStyle { Fill = Theme.BgChip, Border = Theme.Accent, Stripe = Theme.Accent, Text = Theme.TextHi };
                case NodeKind.Observation:
                    return new NodeStyle { Fill = Theme.BgCardTop, Border = Theme.Border, Stripe = Theme.Info, Text = Theme.Text };
                case NodeKind.Hypothesis:
                    {
                        Color band = n.Status == NodeStatus.Suspended ? Theme.Warn
                                   : n.Status == NodeStatus.BestSupported ? Theme.Accent : BandColor(n.Band);
                        return new NodeStyle { Fill = Theme.BgCardTop, Border = band, Stripe = band, Text = Theme.TextHi };
                    }
                case NodeKind.Test:
                    return new NodeStyle { Fill = Theme.BgCardTop, Border = Theme.Info, Stripe = Theme.Info, Text = Theme.TextHi };
                case NodeKind.Outcome:
                    {
                        Color c = n.Verdict == EvidenceVerdict.Pass ? Theme.Good
                                : n.Verdict == EvidenceVerdict.Fail ? Theme.Bad : Theme.TextMut;
                        return new NodeStyle { Fill = Theme.BgCardTop, Border = c, Stripe = c, Text = Theme.Text };
                    }
                default: // Fix
                    return new NodeStyle { Fill = Theme.BgChip, Border = Theme.Accent, Stripe = Theme.Accent, Text = Theme.TextHi };
            }
        }

        private static string KindLabel(ReasoningNode n)
        {
            switch (n.Kind)
            {
                case NodeKind.Root: return "CONNECT";
                case NodeKind.Observation: return n.Source == "dtc" ? "DTC" : n.Source == "vin" ? "VEHICLE" : "OBSERVED";
                case NodeKind.Test: return "TEST";
                case NodeKind.Outcome: return "OUTCOME";
                case NodeKind.Fix: return "FIX";
                default: return n.Kind.ToString().ToUpperInvariant();
            }
        }

        private static Color BandColor(FaultBand b)
        {
            switch (b)
            {
                case FaultBand.Leading: return Theme.Accent;
                case FaultBand.Contending: return Theme.Info;
                case FaultBand.Trailing: return Theme.Warn;
                default: return Theme.TextDim;
            }
        }

        private static GraphicsPath Round(RectangleF r, float radius)
        {
            float d = radius * 2;
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        // ── Interaction ─────────────────────────────────────────────────────────

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (_nodes.Count == 0) return;
            var pt = new PointF(e.X - AutoScrollPosition.X, e.Y - AutoScrollPosition.Y);
            foreach (var kv in _rects)
            {
                if (kv.Value.Contains(pt))
                {
                    _selected = kv.Key;
                    Invalidate();
                    if (_nodeById.TryGetValue(kv.Key, out var node))
                        try { SelectedNodeChanged?.Invoke(node); } catch { }
                    return;
                }
            }
        }
    }
}
