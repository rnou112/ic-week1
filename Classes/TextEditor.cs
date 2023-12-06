using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDev_Week1.Classes
{
    using System;
    using System.Collections.Generic;

    class TextEditor
    {
        private Stack<string> undoStack = new Stack<string>();
        private Stack<string> redoStack = new Stack<string>();

        public string Text { get; private set; }

        public void SetText(string text)
        {
            undoStack.Push(Text);
            Text = text;
            redoStack.Clear();
        }

        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(Text);
                Text = undoStack.Pop();
            }
        }

        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(Text);
                Text = redoStack.Pop();
            }
        }
    }
}
