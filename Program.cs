namespace Dictionary;
class Program
{
    public static void Display(Dictionary<char, List<string>> dictionary){
        foreach(KeyValuePair<char, List<string>> f in dictionary){
            foreach(string s in f.Value){
                Console.WriteLine("Key: {0}, Value: {1}", f.Key, s);
            }
        }
    }
    static void Main(string[] args)
    {
        Dictionary<char, List<string>> dictionary = new Dictionary<char, List<string>>();
        dictionary['a'] = new List<string> {"arc", "alabasta", "ami"};
        dictionary['b'] = new List<string> {"banane", "buisson", "but"};
        dictionary.Add('c', new List<string> {"chat", "cerise", "carreau"});

        Display(dictionary);

        Console.WriteLine("The current size of the dictionary is: " + dictionary.Count);

        dictionary.Remove('c');
        Display(dictionary);
        Console.WriteLine("The current size of the dictionary is: " + dictionary.Count);
    }
}
