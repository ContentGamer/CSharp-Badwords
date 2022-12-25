namespace BadWordFilter;

public class Filter
{
    private string profanityWord = "*";
    private string[] contents = new BadWords()._wordList;

    public Filter(string placeHolder = "*") {
        this.profanityWord = placeHolder;
    }

    private string CloneProfanityWord(string cussWord) {
        string result = "";
        for (var i = 0; i < cussWord.Length; i++) {
            result += profanityWord;
        }
        return result;
    }

    public string clean(string word) {
        string newWord = word.ToLower();
        foreach (string content in contents) {
            if(word.ToLower().Contains(content)) {
                newWord = word.Replace(content, CloneProfanityWord(content));
            }
        }
        return newWord;
    }

    public dynamic isProfanity(string word, bool returnString) {
        dynamic result = true;
        if(returnString) result = "GOOD WORD";
        foreach (string content in contents) {
            if(word.ToLower().Contains(content)) {
                result = false;
                if(returnString) result = "BAD WORD";
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