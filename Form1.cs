using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExNotePad
{

    public partial class Form1 : Form
    {

        private string saveTitle = "";

        private string saveBody = "";

        private string saveFilePath = "";

        private OpenFileDialog openFileDialog;

        private SaveFileDialog saveFileDialog;

        private bool mouseDown = false;

        public Form1()
        {
            InitializeComponent();
            ChangeTitle();
        }

        private void VisibleStatusToolStripMenuItem_CheckedChanged(Object sender, EventArgs e)
        {
            bottomLayoutPanel.Visible = visibleStatusToolStripMenuItem.Checked;
            ChangeBottomLineText();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BodyTextBox_TextChanged(object sender, EventArgs e)
        {
            ChangeTitle();
            ChangeBottomLineText();
        }

        private void ChangeTitle()
        {
            string title = saveTitle;
            if (bodyTextBox.Text.Length != 0) title = ("*" + title);
            if (saveTitle.Equals(""))
            {
                title += "제목 없음 - 메모장";
            }
            Text = title;
        }

        private bool Save()
        {
            bool result = true;

            // 저장
            if (CheckModify())
            {
                if (!saveBody.Equals("") && !saveTitle.Equals(""))
                {
                    SaveFile(saveFilePath);
                }
                else
                {
                    result = SaveDialog();
                }
            }

            return result;
        }

        private void NewMake()
        {
            // 새로 만들기
            saveTitle = "";
            saveBody = "";
            saveFilePath = "";

            this.Text = "";
            this.bodyTextBox.Text = "";
        }

        private void Open()
        {
            // 열기
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "열기";
            openFileDialog.Filter = "텍스트 문서(*.txt)|*.txt|모든 파일|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 열기 대상 파일 경로
                string openFilePosition = openFileDialog.FileName;

                saveFilePath = openFilePosition;

                int openPosition = openFileDialog.FileName.LastIndexOf("\\");

                string textFileName = openFileDialog.FileName.Substring(openPosition + 1);

                StreamReader streamReader = new StreamReader(openFilePosition);

                saveBody = streamReader.ReadToEnd();

                bodyTextBox.Text = null;
                bodyTextBox.Text = saveBody;

                saveTitle = textFileName;

                this.Text = saveTitle;

                streamReader.Close();
            }
        }

        // 새로만들기 메뉴 클릭
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckModify())
            {
                DialogResult dialogResult = CustomMessageBox.ShowBox(
                "메모장",
                "변경 내용을 " + (saveTitle.Equals("") ? "제목 없음" : saveTitle) + "에 저장하시겠습니까?",
                "저장(S)",
                "저장 안 함(N)",
                "취소");

                if (dialogResult == DialogResult.Yes)
                {
                    if (Save())
                    {
                        CustomMessageBox.CloseBox();
                        NewMake();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    CustomMessageBox.CloseBox();
                    NewMake();
                }
            }
            else
            {
                NewMake();
            }
        }

        private bool CloseForm()
        {
            bool result = false;

            // 1. 저장된 값이 없고 입력값이 있는경우
            // 2. 저장된 값이 있고 입력값이 바뀐경우
            if (CheckModify())
            {
                DialogResult dialogResult = CustomMessageBox.ShowBox(
                "메모장",
                "변경 내용을 " + (saveTitle.Equals("") ? "제목 없음" : saveTitle) + "에 저장하시겠습니까?",
                "저장(S)",
                "저장 안 함(N)",
                "취소");

                if (dialogResult == DialogResult.Yes)
                {
                    if (!Save())
                    {
                        result = true;
                    }
                }
                else if(dialogResult == DialogResult.Cancel)
                {
                    result = true;
                }
            }

            return result;
        }

        private bool CheckModify()
        {
            return (saveBody.Equals("") && bodyTextBox.Text.Length > 0)
                || (!saveBody.Equals("") && !saveBody.Equals(bodyTextBox.Text));
        }

        private void SaveFile(string filePosition)
        {
            FileStream fileStream = new FileStream(filePosition, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(this.bodyTextBox.Text);

            streamWriter.Close();

            saveFilePath = filePosition;

            int position = filePosition.LastIndexOf("\\");

            string textFileName = filePosition.Substring(position + 1);

            saveTitle = textFileName;

            this.Text = saveTitle;

            saveBody = this.bodyTextBox.Text;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (CheckModify())
            {
                DialogResult dialogResult = CustomMessageBox.ShowBox(
                "메모장",
                "변경 내용을 " + (saveTitle.Equals("") ? "제목 없음" : saveTitle) + "에 저장하시겠습니까?",
                "저장(S)",
                "저장 안 함(N)",
                "취소");

                if (dialogResult == DialogResult.Yes)
                {
                    if (Save())
                    {
                        CustomMessageBox.CloseBox();
                        Open();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    CustomMessageBox.CloseBox();
                    Open();
                }
            }
            else
            {
                Open();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void ChangeBottomLineText()
        {
            int line = bodyTextBox.GetLineFromCharIndex(bodyTextBox.SelectionStart) + 1;
            int column = bodyTextBox.SelectionStart - bodyTextBox.GetFirstCharIndexOfCurrentLine() + 1;

            bottomTextBox1.Text = "Ln " + line + ", Col " + column;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // e.Cancel, true = 종료 취소, false = 종료 (default : false)
            e.Cancel = CloseForm();
        }

        private void bodyTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeBottomLineText();
            mouseDown = true;
        }

        private void bodyTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                ChangeBottomLineText();
            }
        }

        private void bodyTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeBottomLineText();
            mouseDown = false;
        }

        private void bodyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeBottomLineText();
        }

        private void bodyTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ChangeBottomLineText();
        }

        private void otherNameSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDialog();
        }

        private bool SaveDialog()
        {
            bool result = true;

            saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "c:\\";                            // 기본 저장 경로
            saveFileDialog.Title = "다른 이름으로 저장";                         // 창 타이틀
            saveFileDialog.Filter = "텍스트 문서(*.txt)|*.txt|모든 파일|*.*";    // 파일 형식
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;                                  // 확장명 추가 여부

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveFileDialog.FileName);
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
