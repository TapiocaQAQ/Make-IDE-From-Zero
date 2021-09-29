using System.IO;
using System.Collections.Generic;
namespace Make_IDE_From_Zero
{
    class KeyWords
    {
        public string name;
        public string[] keywords;
        public string color;


        public KeyWords(string n, string[] k, string c) {
            name = n;
            keywords = k;
            color = c;
        }
    }

    static class PassKeyWords {
        static public KeyWords[] keyWords;
    }

    static class UpDate
    {
         static public void UpdateColor(int index, string color)
         {
             if (index < PassKeyWords.keyWords.Length)  PassKeyWords.keyWords[index].color = color;
             string[] colorlist = Form1.colorlist;
             colorlist[index] = color;
             StreamWriter sw;
             FileInfo f = new FileInfo("ColorList.txt");
             sw = f.CreateText();
             foreach (string ele in colorlist) {
                 sw.WriteLine(ele);
             }
             sw.Flush();
             sw.Close();
         }
    }

    public class DoStack 
    {
        public Stack<string> UndoStack;
        public Stack<string> RedoStack;

        public DoStack(){
            UndoStack = new Stack<string>();
            RedoStack = new Stack<string>();
        }
    }
}
