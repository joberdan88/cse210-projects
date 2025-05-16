using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        myJournal._owner = "Jonas";

        Entry entry1 = new Entry();
        entry1._text = "Yesterday was a great day!";
        entry1._date = DateTime.Now;

        myJournal.AddEntry(entry1);
        myJournal.DisplayAll();
    }
}
