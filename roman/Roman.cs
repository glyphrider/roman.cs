﻿namespace roman;
public class Roman
{
    class TransEntry {
        public int arabic;
        public string roman;

        public TransEntry(int arabic, string roman)
        {
            this.arabic = arabic;
            this.roman = roman;
        }
    }

    private TransEntry[] _trans = {
        new TransEntry(1,"I"),
        new TransEntry(4,"IV"),
        new TransEntry(5,"V"),
        new TransEntry(9,"IX"),
        new TransEntry(10,"X"),
        new TransEntry(40,"XL"),
        new TransEntry(50,"L"),
        new TransEntry(90,"XC"),
        new TransEntry(100,"C"),
        new TransEntry(400,"CD"),
        new TransEntry(500,"D"),
        new TransEntry(900,"CM"),
        new TransEntry(1000,"M"),
    };

    private int _value;
    public Roman(int arabic)
    {
        _value = arabic;
    }

    public Roman(string roman)
    {
        _value = 0;
        int index = _trans.Length - 1;
        while(roman.Length > 0) {
            if(roman.StartsWith(_trans[index].roman)) { roman = roman.Substring(_trans[index].roman.Length); _value += _trans[index].arabic; } else { index--; }
        }
    }
    public string To_Roman() {
        string result = "";
        int index = _trans.Length - 1;
        int value = _value;
        while(value > 0) {
            if(value < _trans[index].arabic) { index--; } else { result += _trans[index].roman; value -= _trans[index].arabic; }
        }
        return result;
    }

    public int To_Arabic() {
        return _value;
    }

}
