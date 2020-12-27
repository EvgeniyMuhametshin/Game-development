using System;

    [Serializable]
public class Question
{
     string text;      
     bool trueFalse;   

     public string Text { get { return text; } set { if (value.GetType() == typeof(string)) text = value; } }
     public bool TrueFalse { get { return trueFalse; } set { if (value.GetType() == typeof(bool)) trueFalse = value; } }

    public Question() { }

    public Question(string text, bool trueFalse)
    {
        this.text = text;
        this.trueFalse = trueFalse;
    }
}
