# CSharp-Badwords
recreation of the badwords npm package.

# HOW TO USE

```C#
using BadWordFilter;

public static void Main(string[] args) {
    Filter filter = new Filter();
    string word = "test ----";
    string word2 = "test test";
    string newWord = filter.clean(word); // test ****
    string newWord2 = filter.clean(word2); // test test
    filter.addWords(new string[1]{"test"});
    newWord2 = filter.clean(word2); // **** ****
    filter.removeWords(new string[1]{"test"});
    newWord2 = filter.clean(word2); // test test
}
```
