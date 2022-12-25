namespace BadWordFilter;

public class Filter
{
    private string profanityWord = "*";
    BadWords badwords = new BadWords();
    private List<string> contents = new List<string>();

    public Filter(string placeHolder = "*") {
        badwords.Start();
        contents = badwords._wordList;
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
        foreach (string content in contents.ToArray()) {
            if(word.ToLower().Contains(content)) {
                newWord = word.Replace(content, CloneProfanityWord(content));
            }
        }
        return newWord;
    }

    public dynamic isProfanity(string word, bool returnString = false) {
        dynamic result = true;
        if(returnString) result = "GOOD WORD";
        foreach (string content in contents.ToArray()) {
            if(word.ToLower().Contains(content)) {
                result = false;
                if(returnString) result = "BAD WORD";
            }
        }
        return result;
    }

    public void addWords(string[] words) {
        foreach(string word in words) {
            contents.Add(word);
        }
    }

    public void removeWords(string[] words) {
        foreach(string word in words) {
            contents.Remove(word);
        }
    }

}