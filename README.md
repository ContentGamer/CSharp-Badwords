# CSharp-Badwords
CSharp version of the NPM Javascript Badwords module

# HOW TO USE

```C#
using BadWordsFilter;

public static void Main(string[] args) {
    Filter filter = new Filter();
    string word = "test ass";
    string newWord = filter.clean(word); // test ***
}
```
