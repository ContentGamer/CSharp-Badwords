# CSharp-Badwords
CSharp version of the NPM Javascript Badwords module programmed line by line

# HOW TO USE

```C#
using BadWordFilter;

public static void Main(string[] args) {
    Filter filter = new Filter();
    string word = "test ass";
    string word2 = "test coolguy";
    string newWord = filter.clean(word); // test ***
    string newWord2 = filter.clean(word2); // test coolguy
    filter.addWords(new string[1]{"coolguy"});
    newWord2 = filter.clean(word2); // test *******
    filter.removeWords(new string[1]{"coolguy"});
     newWord2 = filter.clean(word2); // test coolguy
}
```
