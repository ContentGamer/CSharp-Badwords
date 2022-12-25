namespace BadWordFilter;

using System;
using System.IO;

public class Filter
{
    private string profanityWord = "*";

    public Filter(string placeHolder = "*") {
        this.profanityWord = placeHolder;
    }

    public string clean(string word) {
        string filePath = Directory.GetCurrentDirectory()+"\\badwords.txt";
        string[] contents = File.ReadAllLines(filePath);
        string newWord = word.ToLower();
        foreach (string content in contents) {
            if(word.ToLower() == content) {
                newWord = word.Replace(content, content.Replace(content, profanityWord));
            }
        }
        return newWord;
    }

    public bool isProfanity(string word) {
        string filePath = Directory.GetCurrentDirectory()+"\\badwords.txt";
        string[] contents = File.ReadAllLines(filePath);
        bool result = true;
        foreach (string content in contents) {
            if(word.ToLower() == content) {
                result = false;
            }
        }
        return result;
    }

    public void addWords(string[] words) {
        string filePath = Directory.GetCurrentDirectory()+"\\badwords.txt";
        StreamWriter writer = new StreamWriter(filePath);
        foreach(string word in words) {
            writer.WriteLine(word.ToLower());
        }
    }

    public void removeWords(string[] words) {
        string filePath = Directory.GetCurrentDirectory()+"\\badwords.txt";
        string content = File.ReadAllText(filePath);
        foreach(string word in words) {
            content = content.Replace(word.ToLower(), "");
        }
        File.WriteAllText(filePath, content);
    }

}
