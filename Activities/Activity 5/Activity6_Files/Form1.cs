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

namespace Activity7_MathForLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            //if the button ok was clicked from the file dialog
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                int count = 0;
                string longWord = "";

                int vowelMax = -1;
                string maxVowel = "";

                //get the file
                string filePath = fileDialog.FileName;
                //get the file content to lowercase and display the content in text box
                string fileContent = File.ReadAllText(filePath).ToLower();
                txt_Main.Text = fileContent;

                //go through file content and split up the words
                string allWords = fileContent;
                string[] wordsArray = allWords.Split(' ','.', ',', '(', ')', '-', '!', '\r', '\n');


                string firstWord = wordsArray[0];
                string lastWord = wordsArray[wordsArray.Length - 1];

                // go through each word in the array and add them to the listbox (only if it is a new word)
                foreach (string word in wordsArray)
                {
                    if (!listBox1.Items.Contains(word))
                    {
                        listBox1.Items.Add(word);
                    }
                    //then check the word length and see if it is the longest word
                    if (word.Length > count)
                    {
                        longWord = word;
                        count = word.Length;
                    }

                    //then check if the current word has the most vowels
                    int vowels = 0;
                    for(int i = 0; i < word.Length; i++)
                    {
                        char c = word[i];
                        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') vowels++;
                    }
                    if(vowels > vowelMax)
                    {
                        vowelMax = vowels;
                        maxVowel = word;
                    }

                    //and finally find the first and last word alphbetically
                    if (word.CompareTo(firstWord) < 0) firstWord = word;
                    if (word.CompareTo(lastWord) > 0) lastWord = word;
                }
                listBox1.Sorted = true;

                txt_A.Text = firstWord;
                txt_Z.Text = lastWord;
                txt_Long.Text = longWord;
                txt_Vowels.Text = maxVowel;

            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Main.Clear();
            txt_A.Clear();
            txt_Z.Clear();
            txt_Long.Clear();
            txt_Vowels.Clear();
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                BinaryWriter binaryWriter = new BinaryWriter(File.Create(path));

                binaryWriter.Write("First Alphabetical Word: " + txt_A.Text + "\n" +
                                   "Last Alphabetical Word: " + txt_Z.Text + "\n" +
                                   "Longest Word: " + txt_Long.Text + "\n" +
                                   "Word with Most Vowels: " + txt_Vowels.Text + "\n" +
                                   "YOUR TEXT:"+"\n"+
                                   txt_Main.Text);
                binaryWriter.Dispose();
            }
        }
    }
}
