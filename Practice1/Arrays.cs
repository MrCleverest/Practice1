using System;
using System.Linq;
using System.Windows.Forms;

public class Arrays
{
    public bool error = false;
    string[] surnames;
    static int length = 5;
    public int Length
    {
        get { return length; }
        set { length = value; }
    }

    public string this[int i]
    {
        get
        {
            if (0 <= i && i < length)
            {
                return surnames[i];
            }
            else
            {
                error = true;
                return "Помилка";
            }
        }
        set
        {
            if(0 <= i && i < length)
            {
                surnames[i] = value;
            }
            else
            {
                error = true;
            }
        }

    }

    public Arrays()
    {
        surnames = new string[length];
        surnames[0] = "Ващенко";
        surnames[1] = "Гармаш";
        surnames[2] = "Бульба";
        surnames[3] = "Гоголь";
        surnames[4] = "Новицький";
    }

    public Arrays(string surname, string surname1, string surname2, string surname3, string surname4)
    {
        surnames = new string[length];
        surnames[0] = surname;
        surnames[1] = surname1;
        surnames[2] = surname2;
        surnames[3] = surname3;
        surnames[4] = surname4;
    }

    public void SortByLastLetter()
    {
        Array.Sort(surnames);
        Array.Reverse(surnames);
    }
}
