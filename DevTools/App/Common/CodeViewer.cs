using DevTools.App.Common;
using ScintillaNET;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevTools.App.CSharp
{
    public partial class CodeViewer : Form
    {
        private Scintilla TextArea;
        public CodeViewer(CodeSnippet snippetItems)
        {
            InitializeComponent();
            lbFileName.Text = snippetItems.Name;
            TextArea = new Scintilla();
            TextPanel.Controls.Add(TextArea);
            TextArea.Dock = DockStyle.Fill;
            TextArea.WrapMode = WrapMode.None;
            TextArea.IndentationGuides = IndentView.LookBoth;
            TextArea.SetSelectionBackColor(true, IntToColor(0x114D9C));
            InitNumberMargin();
            InitLangageColoring(Path.GetExtension(snippetItems.Path));
            LoadFileContentAsync(snippetItems);
        }
        private void LoadFileContentAsync(CodeSnippet snippetItems)
        {
            try
            {
                string fileContent = snippetItems.GetFileContent(); 
                TextArea.Text = fileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitLangageColoring(string fileExtension)
        {
            Init_Default_SyntaxColoring();
            switch (fileExtension)
            {
                case ".cpp":
                case ".cs":
                    TextArea.Lexer = Lexer.Cpp;
                    Init_CPP_CS_SyntaxColoring();
                    break;
                case ".html":
                    TextArea.Lexer = Lexer.Html;
                    Init_HTML_SyntaxColoring();
                    break;
                case ".css":
                    TextArea.Lexer = Lexer.Css;
                    Init_Css_SyntaxColoring();
                    break;
                case ".py":
                    TextArea.Lexer = Lexer.Python;
                    Init_Python_SyntaxColoring();
                    break;
                case ".bat":
                case ".cmd":
                    TextArea.Lexer = Lexer.Batch;
                    Init_Batch_SyntaxColoring();
                    break;
                case ".ps1":
                    TextArea.Lexer = Lexer.PowerShell;
                    Init_Powershell_SyntaxColoring();
                    break;
                default:
                    break;
            }
        }
        private void Init_Default_SyntaxColoring()
        {
            TextArea.StyleResetDefault();
            TextArea.Styles[Style.Default].Font = "Consolas";
            TextArea.Styles[Style.Default].Size = 10;
            TextArea.Styles[Style.Default].BackColor = IntToColor(0xD3D3D3);
            TextArea.Styles[Style.Default].ForeColor = IntToColor(0x000000);
            TextArea.StyleClearAll();
        }

        private void Init_Powershell_SyntaxColoring()
        {
            TextArea.Styles[Style.PowerShell.Default].ForeColor = Color.Black;
            TextArea.Styles[Style.PowerShell.Comment].ForeColor = Color.Green;
            TextArea.Styles[Style.PowerShell.String].ForeColor = Color.OrangeRed;
            TextArea.Styles[Style.PowerShell.Character].ForeColor = Color.Black;
            TextArea.Styles[Style.PowerShell.Number].ForeColor = Color.Black;
            TextArea.Styles[Style.PowerShell.Variable].ForeColor = Color.Blue;
            TextArea.Styles[Style.PowerShell.Operator].ForeColor = Color.Black;
            TextArea.Styles[Style.PowerShell.Cmdlet].ForeColor = Color.Blue;
            TextArea.Styles[Style.PowerShell.Alias].ForeColor = Color.Blue;
            TextArea.Styles[Style.PowerShell.Function].ForeColor = Color.Blue;
            TextArea.Styles[Style.PowerShell.User1].ForeColor = Color.Blue;
            TextArea.Styles[Style.PowerShell.CommentStream].ForeColor = Color.Green;

            string keywords = "Add-Content Add-History Add-Member Add-PSSnapin Clear-Content Clear-Item Clear-ItemProperty Clear-Variable Compare-Object ConvertFrom-SecureString Convert-Path ConvertTo-Html ConvertTo-SecureString Copy-Item Copy-ItemProperty Export-Alias Export-Clixml Export-Console Export-Csv ForEach-Object Format-Custom Format-List Format-Table Format-Wide Get-Acl Get-Alias Get-AuthenticodeSignature Get-ChildItem Get-Command Get-Content Get-Credential Get-Culture Get-Date Get-EventLog Get-ExecutionPolicy Get-Help Get-History Get-Host Get-Item Get-ItemProperty Get-Location Get-Member Get-PfxCertificate Get-Process Get-PSSnapin Get-Random Get-Service Get-Tracesource Get-UICulture Get-Unique Get-Variable Group-Object Import-Alias Import-Clixml Import-Csv Invoke-Expression Invoke-History Invoke-Item Join-Path Measure-Command Measure-Object Move-Item Move-ItemProperty New-Alias New-Item New-ItemProperty New-Object New-TimeSpan Out-Default Out-file Out-host Out-null Out-printer Out-string Pop-location Push-location Read-host Remove-item Remove-itemproperty Remove-psdrive Remove-pssnapin Remove-variable Rename-item Rename-itemproperty Resolve-path Restart-service Resume-service Select-object Select-string Set-acl Set-Alias Set-authenticodesignature Set-content Set-date Set-executionpolicy Set-item Set-itemproperty Set-location Set-psdebug Set-service Set-tracesource Set-variable Show-eventlog Sort-object Split-path Start-service Start-sleep Start-transcript Stop-process Stop-service Stop-transcript Suspend-service Tee-object Test-path Trace-command Update-formatdata Update-typedata Where-object Write-debug Write-error Write-host Write-output Write-progress Write-warning";
            string keywords2 = "ac asnp clc cli clp clv cpi cpp cvpa diff epal epcsv fc fl foreach ft fw gal gbp gc gci gcm gcs gdr ghy gi gl gm gp gps group gsv gu gv gwmi iex ihy ii ipal ipcsv mi mp nal ndr ni nv oh popd ps pushd r rbp rcjb rcsn rd rdr ren ri rni rnp rp rsnp rv rvpa sal saps sasv sbp sc select si sl sleep sort sp spps start sv tee cat cd cp h history kill lp ls mount mv popd ps pushd pwd r rm rmdir echo cls chdir del dir erase rd type % $$ ? ^";

            TextArea.SetKeywords(0, keywords);
            TextArea.SetKeywords(1, keywords2);
        }

        private void Init_Batch_SyntaxColoring()
        {
            TextArea.Styles[Style.Batch.Default].ForeColor = Color.Black;
            TextArea.Styles[Style.Batch.Comment].ForeColor = Color.Green;
            TextArea.Styles[Style.Batch.Word].ForeColor = Color.Blue;
            TextArea.Styles[Style.Batch.Label].ForeColor = Color.Blue;
            TextArea.Styles[Style.Batch.Hide].ForeColor = Color.Black;
            TextArea.Styles[Style.Batch.Command].ForeColor = Color.Black;
            TextArea.Styles[Style.Batch.Identifier].ForeColor = Color.Black;
            TextArea.Styles[Style.Batch.Operator].ForeColor = Color.Black;

            string keywords = "assoc attrib break call cd chcp chdir choice cls cmd color com comp compact con convert copy country ctty date defined del dir diskcomp diskcopy do doskey echo else endlocal equ erase errorlevel exist exit expand fc find findstr for ftype geq goto gtr if in leq lfnfor lss md mkdir more move neq not nul off on path pause popd print prompt pushd rd rem ren rename replace restore rmdir set setlocal shift sort start time title tree type ver verify vol";
            TextArea.SetKeywords(0, keywords);
        }

        private void Init_Python_SyntaxColoring()
        {
            TextArea.Styles[Style.Python.Default].ForeColor = Color.Black;
            TextArea.Styles[Style.Python.CommentLine].ForeColor = Color.Green;
            TextArea.Styles[Style.Python.CommentBlock].ForeColor = Color.Green;
            TextArea.Styles[Style.Python.Number].ForeColor = Color.Purple;
            TextArea.Styles[Style.Python.String].ForeColor = Color.Red;
            TextArea.Styles[Style.Python.Character].ForeColor = Color.Black;
            TextArea.Styles[Style.Python.Word].ForeColor = Color.Blue;
            TextArea.Styles[Style.Python.Triple].ForeColor = Color.Green;
            TextArea.Styles[Style.Python.TripleDouble].ForeColor = Color.Black;
            TextArea.Styles[Style.Python.ClassName].ForeColor = Color.Blue;
            TextArea.Styles[Style.Python.DefName].ForeColor = Color.Blue;
            TextArea.Styles[Style.Python.Operator].ForeColor = Color.Black;
            TextArea.Styles[Style.Python.Identifier].ForeColor = Color.Black;
            TextArea.Styles[Style.Python.CommentBlock].ForeColor = Color.Green;
            TextArea.Styles[Style.Python.StringEol].ForeColor = Color.Black;
            TextArea.Styles[Style.Python.Word2].ForeColor = Color.Blue;
            TextArea.Styles[Style.Python.Decorator].ForeColor = Color.Blue;

            string keywords = "and as assert break class continue def del elif else except False finally for from global if import in is lambda None nonlocal not or pass raise return True try while with yield";
            string keywords2 = "abs all any ascii bin bool bytearray bytes callable chr classmethod compile complex delattr dict dir divmod enumerate eval exec filter float format frozenset getattr globals hasattr hash help hex id input int isinstance issubclass iter len list locals map max memoryview min next object oct open ord pow print property range repr reversed round set setattr slice sorted staticmethod str sum super tuple type vars zip __import__";
            TextArea.SetKeywords(0, keywords);
            TextArea.SetKeywords(1, keywords2);
        }

        private void Init_Css_SyntaxColoring()
        {
            TextArea.Styles[Style.Css.Default].ForeColor = Color.Black;
            TextArea.Styles[Style.Css.Tag].ForeColor = Color.Blue;
            TextArea.Styles[Style.Css.Class].ForeColor = Color.Blue;
            TextArea.Styles[Style.Css.PseudoClass].ForeColor = Color.Blue;
            TextArea.Styles[Style.Css.UnknownPseudoClass].ForeColor = Color.Blue;
            TextArea.Styles[Style.Css.Operator].ForeColor = Color.Black;
            TextArea.Styles[Style.Css.Identifier].ForeColor = Color.Red;
            TextArea.Styles[Style.Css.UnknownIdentifier].ForeColor = Color.Red;
            TextArea.Styles[Style.Css.Value].ForeColor = Color.Black;
            TextArea.Styles[Style.Css.Comment].ForeColor = Color.Green;
            TextArea.Styles[Style.Css.Id].ForeColor = Color.Blue;
            TextArea.Styles[Style.Css.Important].ForeColor = Color.Black;
            TextArea.Styles[Style.Css.Directive].ForeColor = Color.Black;
            TextArea.Styles[Style.Css.DoubleString].ForeColor = Color.Black;
            TextArea.Styles[Style.Css.SingleString].ForeColor = Color.Black;
            TextArea.Styles[Style.Css.Identifier2].ForeColor = Color.Red;
            TextArea.Styles[Style.Css.Attribute].ForeColor = Color.Red;
        }

        private void Init_HTML_SyntaxColoring()
        {
            TextArea.Styles[Style.Html.Default].ForeColor = Color.Black;
            TextArea.Styles[Style.Html.Tag].ForeColor = Color.Blue;
            TextArea.Styles[Style.Html.TagUnknown].ForeColor = Color.Blue;
            TextArea.Styles[Style.Html.Attribute].ForeColor = Color.Red;
            TextArea.Styles[Style.Html.AttributeUnknown].ForeColor = Color.Red;
            TextArea.Styles[Style.Html.Number].ForeColor = Color.Black;
            TextArea.Styles[Style.Html.DoubleString].ForeColor = Color.Black;
            TextArea.Styles[Style.Html.SingleString].ForeColor = Color.Black;
            TextArea.Styles[Style.Html.Other].ForeColor = Color.Black;
            TextArea.Styles[Style.Html.Comment].ForeColor = Color.Green;
            TextArea.Styles[Style.Html.Entity].ForeColor = Color.Black;
            TextArea.Styles[Style.Html.TagEnd].ForeColor = Color.Blue;
            TextArea.Styles[Style.Html.XmlStart].ForeColor = Color.Blue;
            TextArea.Styles[Style.Html.XmlEnd].ForeColor = Color.Blue;
            TextArea.Styles[Style.Html.Script].ForeColor = Color.Black;
            TextArea.Styles[Style.Html.Asp].ForeColor = Color.Black;
            TextArea.Styles[Style.Html.AspAt].ForeColor = Color.Black;
            TextArea.Styles[Style.Html.CData].ForeColor = Color.Black;
            TextArea.Styles[Style.Html.Question].ForeColor = Color.Black;
            TextArea.Styles[Style.Html.Value].ForeColor = Color.Black;
        }

        private void Init_CPP_CS_SyntaxColoring()
        {
            TextArea.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0x000000);
            TextArea.Styles[Style.Cpp.Number].ForeColor = IntToColor(0x657EF7);
            TextArea.Styles[Style.Cpp.String].ForeColor = IntToColor(0xB01C1C);
            TextArea.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xDC143C);
            TextArea.Styles[Style.Cpp.Preprocessor].ForeColor = Color.Gray;
            TextArea.Styles[Style.Cpp.EscapeSequence].ForeColor = IntToColor(0xF5B3DE);

            TextArea.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0x000000);
            TextArea.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xB3F5EC);
            TextArea.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x008B8B);
            TextArea.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x2244F0);
            TextArea.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0x6E6E6E);
            TextArea.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0x6B8E23);
            TextArea.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = Color.Red;
            TextArea.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0x008B8B);
            TextArea.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x008B8B);
            TextArea.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x008B8B);
            TextArea.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0xB3BEF5);

            TextArea.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
            TextArea.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");
        }

        private void InitNumberMargin()
        {
            const int BACK_COLOR = 0xFFFFFF;
            const int FORE_COLOR = 0x000000;
            const int NUMBER_MARGIN = 1;

            TextArea.Styles[Style.LineNumber].BackColor = IntToColor(BACK_COLOR);
            TextArea.Styles[Style.LineNumber].ForeColor = IntToColor(FORE_COLOR);
            TextArea.Styles[Style.IndentGuide].ForeColor = IntToColor(FORE_COLOR);
            TextArea.Styles[Style.IndentGuide].BackColor = IntToColor(BACK_COLOR);

            var nums = TextArea.Margins[NUMBER_MARGIN];
            nums.Width = 30;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;

        }

        private static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextArea.Text);

            lbCopy?.Invoke((MethodInvoker)delegate
            {
                lbCopy.Visible = true;
            });

            Task.Delay(2000).ContinueWith(_ =>
            {
                lbCopy?.Invoke((MethodInvoker)delegate
                {
                    lbCopy.Visible = false;
                });
            });
        }
    }
}
