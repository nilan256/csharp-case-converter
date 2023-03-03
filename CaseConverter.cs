using System.Collections.Generic;
using System.Text;

/// <summary>
/// Convert text between any case.
/// Usage: NamingCaseConverter.ToSnake("thisIsMyName") -> "this_is_my_name"
/// </summary>
public class CaseConverter {
    
    
    /// <summary>
    /// <para>Used for split text to words.</para>
    /// <para>Other symbols will be a part of word, e.g. ToSnake("myName+") -> "my_name+".</para>
    /// </summary>
    public static HashSet<char> Delimiters = new HashSet<char>() {
        '-',
        '_',
        '.',
        ' ',
    };

    /// <summary>
    /// <para>Single lowercase prefix will be ignored.</para>
    /// <para>example: "mMyName" to snake -> "my_name"</para>
    /// <para>If false, example result will be "m_my_name"</para>
    /// </summary>
    public static bool EnableHungarianNotationParsing = true;

    
    /// <summary>
    /// output: "thisIsMyName"
    /// </summary>
    public static string ToCamel(string str) {
        var output = new StringBuilder();
        var words = Split(str);
        for (var i = 0; i < words.Count; i++) {
            var word = words[i];
            for (var j = 0; j < word.Length; j++) {
                var chr = word[j];
                if (i > 0 && j == 0) {
                    chr = char.ToUpper(chr);
                }
                output.Append(chr);
            }
        }
        return output.ToString();
    }


    /// <summary>
    /// output: "ThisIsMyName"
    /// </summary>
    public static string ToPascal(string str) {
        var output = new StringBuilder();
        var words = Split(str);
        for (var i = 0; i < words.Count; i++) {
            var word = words[i];
            for (var j = 0; j < word.Length; j++) {
                var chr = word[j];
                if (j == 0) {
                    chr = char.ToUpper(chr);
                }
                output.Append(chr);
            }
        }
        return output.ToString();
    }


    /// <summary>
    /// output: "this_is_my_name"
    /// </summary>
    public static string ToSnake(string str) {
        var words = Split(str);
        return string.Join('_', words);
    }

    /// <summary>
    /// output: "This_Is_My_Name"
    /// </summary>
    public static string ToAda(string str) {
        var output = new StringBuilder();
        var words = Split(str);
        for (var i = 0; i < words.Count; i++) {
            if (i > 0) output.Append('_');
            var word = words[i];
            for (var j = 0; j < word.Length; j++) {
                var chr = word[j];
                if (j == 0) {
                    chr = char.ToUpper(chr);
                }
                output.Append(chr);
            }
        }
        return output.ToString();
    }


    /// <summary>
    /// output: "THIS_IS_MY_NAME"
    /// </summary>
    public static string ToMarco(string str) {
        var output = new StringBuilder();
        var words = Split(str);
        for (var i = 0; i < words.Count; i++) {
            if (i > 0) output.Append('_');
            var word = words[i];
            for (var j = 0; j < word.Length; j++) {
                var chr = word[j];
                chr = char.ToUpper(chr);
                output.Append(chr);
            }
        }
        return output.ToString();
    }
    
    
    /// <summary>
    /// output: "this-is-my-name"
    /// </summary>
    public static string ToKebab(string str) {
        var words = Split(str);
        return string.Join('-', words);
    }

    
    /// <summary>
    /// output: "This_Is_My_Name"
    /// </summary>
    public static string ToTrain(string str) {
        var output = new StringBuilder();
        var words = Split(str);
        for (var i = 0; i < words.Count; i++) {
            if (i > 0) output.Append('-');
            var word = words[i];
            for (var j = 0; j < word.Length; j++) {
                var chr = word[j];
                if (j == 0) {
                    chr = char.ToUpper(chr);
                }
                output.Append(chr);
            }
        }
        return output.ToString();
    }
    
    
    /// <summary>
    /// output: "THIS-IS-MY-NAME"
    /// </summary>
    public static string ToCobol(string str) {
        var output = new StringBuilder();
        var words = Split(str);
        for (var i = 0; i < words.Count; i++) {
            if (i > 0) output.Append('-');
            var word = words[i];
            for (var j = 0; j < word.Length; j++) {
                var chr = word[j];
                chr = char.ToUpper(chr);
                output.Append(chr);
            }
        }
        return output.ToString();
    }
    
    
    /// <summary>
    /// output: "this is my name"
    /// </summary>
    public static string ToLower(string str) {
        var words = Split(str);
        return string.Join(' ', words);
    }
    
    
    /// <summary>
    /// output: "THIS IS MY NAME"
    /// </summary>
    public static string ToUpper(string str) {
        var output = new StringBuilder();
        var words = Split(str);
        for (var i = 0; i < words.Count; i++) {
            if (i > 0) output.Append(' ');
            var word = words[i];
            for (var j = 0; j < word.Length; j++) {
                var chr = word[j];
                chr = char.ToUpper(chr);
                output.Append(chr);
            }
        }
        return output.ToString();
    }
    
    
    /// <summary>
    /// output: "This Is My Name"
    /// </summary>
    public static string ToTitle(string str) {
        var output = new StringBuilder();
        var words = Split(str);
        for (var i = 0; i < words.Count; i++) {
            if (i > 0) output.Append(' ');
            var word = words[i];
            for (var j = 0; j < word.Length; j++) {
                var chr = word[j];
                if (j == 0) {
                    chr = char.ToUpper(chr);
                }
                output.Append(chr);
            }
        }
        return output.ToString();
    }

    
    /// <summary>
    /// output: "This is my name"
    /// </summary>
    public static string ToSentence(string str) {
        var output = new StringBuilder();
        var words = Split(str);
        for (var i = 0; i < words.Count; i++) {
            if (i > 0) output.Append(' ');
            var word = words[i];
            for (var j = 0; j < word.Length; j++) {
                var chr = word[j];
                if (i == 0 && j == 0) {
                    chr = char.ToUpper(chr);
                }
                output.Append(chr);
            }
        }
        return output.ToString();
    }
    
    
    /// <summary>
    /// output: "this.is.my.name"
    /// </summary>
    public static string ToDot(string str) {
        var words = Split(str);
        return string.Join('.', words);
    }
    

    /// <summary>
    /// <para>Split text to lowercase words. example: "ThisIsMyName" -> ["this", "is", "my", "name"].</para>
    /// <para>If <see cref="EnableHungarianNotationParsing"/> is true, first single letter will be passed.</para>
    /// </summary>
    /// <param name="str">Some text.</param>
    /// <returns>Split words.</returns>
    public static List<string> Split(string str) {
        var ret = new List<string>();
        var buffer = new StringBuilder();
        for (var i = 0; i < str.Length; i++) {
            var chr = str[i];
            
            // split by delimiter
            if (Delimiters.Contains(chr)) {
                if (buffer.Length != 0) {
                    ret.Add(buffer.ToString());
                    buffer.Clear();
                }
                continue;
            }
            
            // split by char case changed
            if (i > 0) {
                var last = str[i - 1];
                if (!char.IsUpper(last) && char.IsUpper(chr)) {
                    if (buffer.Length != 0) {
                        ret.Add(buffer.ToString());
                        buffer.Clear();
                    }
                }
            }
            
            // ensure result is lowercase
            buffer.Append(char.IsUpper(chr) ? char.ToLower(chr) : chr);
        }
        
        if (buffer.Length != 0) {
            ret.Add(buffer.ToString());
            buffer.Clear();
        }

        // remove first letter from Hungarian notation like "mMyData"
        if (EnableHungarianNotationParsing) {
            if (ret.Count > 0 && ret[0].Length == 1) {
                ret.RemoveAt(0);
            }
        }
        
        return ret;
    }

    // public static void Test() {
    //     var text = "ThisIsMyName";
    //     
    //     Console.WriteLine("camel: " + ToCamel(text));
    //     Console.WriteLine("pascal: " + ToPascal(text));
    //     Console.WriteLine("snake: " + ToSnake(text));
    //     Console.WriteLine("ada: " + ToAda(text));
    //     Console.WriteLine("marco: " + ToMarco(text));
    //     Console.WriteLine("kebab: " + ToKebab(text));
    //     Console.WriteLine("train: " + ToTrain(text));
    //     Console.WriteLine("cobol: " + ToCobol(text));
    //     Console.WriteLine("lower: " + ToLower(text));
    //     Console.WriteLine("upper: " + ToUpper(text));
    //     Console.WriteLine("title: " + ToTitle(text));
    //     Console.WriteLine("sentence: " + ToSentence(text));
    //     Console.WriteLine("dot: " + ToDot(text));
    // }

}