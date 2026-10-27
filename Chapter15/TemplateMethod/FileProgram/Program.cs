using TextFileProcessor;

string path = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\Section04\Program.cs";

TextProcessor.Run<KeywordProcessor>(path);

public class KeywordProcessor : TextProcessor {
    private int count;
    private string? keyword;

    protected override void Initialize(string fname) {
        count = 0;
        Console.Write("検索文字列:");
        keyword = Console.ReadLine();
    }

    protected override void Execute(string line) {
        int pos = 0;

        while ((pos = line.IndexOf(keyword!, pos)) != -1) {
            count++;
            pos += keyword!.Length;
        }
        //count += line.Split(keyord).Length -1;
    }

    protected override void Terminate() {
        Console.WriteLine($"{keyword} は {count} 回出現しました");
    }

}