namespace roman;

public class Tests
{
    static object[] testCases = {
    new object[] {1, "I"},
    new object[] {2, "II"},
    new object[] {3, "III"},
    new object[] {4, "IV"},
    new object[] {5, "V"},
    new object[] {6, "VI"},
    new object[] {7, "VII"},
    new object[] {8, "VIII"},
    new object[] {9, "IX"},
    new object[] {11, "XI"},
    new object[] {14, "XIV"},
    new object[] {15, "XV"},
    new object[] {16, "XVI"},
    new object[] {19, "XIX"},
    new object[] {20, "XX"},
    new object[] {21, "XXI"},
    new object[] {39, "XXXIX"},
    new object[] {40, "XL"},
    new object[] {41, "XLI"},
    new object[] {42, "XLII"},
    new object[] {43, "XLIII"},
    new object[] {44, "XLIV"},
    new object[] {45, "XLV"},
    new object[] {46, "XLVI"},
    new object[] {47, "XLVII"},
    new object[] {48, "XLVIII"},
    new object[] {49, "XLIX"},
    new object[] {50, "L"},
    new object[] {89, "LXXXIX"},
    new object[] {90, "XC"},
    new object[] {91, "XCI"},
    new object[] {99, "XCIX"},
    new object[] {100, "C"},
    new object[] {101, "CI"},
    new object[] {200, "CC"},
    new object[] {399, "CCCXCIX"},
    new object[] {400, "CD"},
    new object[] {401, "CDI"},
    new object[] {499, "CDXCIX"},
    new object[] {500, "D"},
    new object[] {501, "DI"},
    new object[] {899, "DCCCXCIX"},
    new object[] {900, "CM"},
    new object[] {999, "CMXCIX"},
    new object[] {1000, "M"},
    new object[] {1001, "MI"},
    new object[] {1968, "MCMLXVIII"},
    };

    [TestCaseSource(nameof(testCases))]
    public void ConvertToRoman(int arabic, string roman)
    {
        Assert.That(new Roman(arabic).To_Roman(), Is.EqualTo(roman));
    }

    [TestCaseSource(nameof(testCases))]
    public void ConvertToArabic(int arabic, string roman)
    {
        Assert.That(new Roman(roman).To_Arabic(),Is.EqualTo(arabic));
    }
}