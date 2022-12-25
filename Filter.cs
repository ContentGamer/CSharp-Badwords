namespace BadWordFilter;

public class Filter
{
    private string profanityWord = "*";
    private string[] contents = new BadWords()._wordList;

    public Filter(string placeHolder = "*") {
        this.profanityWord = placeHolder;
    }

    public string clean(string word) {
        string newWord = word.ToLower();
        foreach (string content in contents) {
            if(word.ToLower() == content) {
                newWord = word.Replace(content, content.Replace(content, profanityWord));
            }
        }
        return newWord;
    }

    public bool isProfanity(string word) {
        bool result = true;
        foreach (string content in contents) {
            if(word.ToLower() == content) {
                result = false;
            }
        }
        return result;
    }

    public void addWords(string[] words) {
        foreach(string word in words) {
            new BadWords()._wordList.Append(word);
            contents = new BadWords()._wordList;
        }
    }

    public void removeWords(string[] words) {
        foreach(string word in words) {
            for(var i = 0; i < new BadWords()._wordList.Length; i++){
                if(new BadWords()._wordList[i] == word) {
                    new BadWords()._wordList[i] = "";
                    contents = new BadWords()._wordList;
                }
            }
        }
    }

}