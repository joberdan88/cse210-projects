//Store the full text and manages word hidding

public class Scripture
{
    public ScriptureReference Reference { get; private set; }
    private List<Word> Words;

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = text.Split(" ").Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        List<Word> visibleWords = Words.Where(word => !word.IsHidden).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public override string ToString()
    {
        return $"{Reference}\n{string.Join(" ", Words)}";
    }
}
