//Represents the word of the scripture and controls wether it is hidden or visible

using System.Runtime.CompilerServices;

public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }


    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}
