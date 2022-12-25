# CSharp-Badwords
CSharp version of the NPM Javascript Badwords module

# HOW TO USE

first thing first you need to download this repository and then when its downloaded copy the badwords.txt and put it into your project & then build the repository to get the dll file then that dll file needs to be in your project then you need to add it as a reference and boom BadWordFilter namespace is succesfully on your project

```C#
using BadWordFilter;

public static void Main(string[] args) {
    Filter filter = new Filter();
    string word = "test ass";
    string newWord = filter.clean(word); // test ***
}
```
