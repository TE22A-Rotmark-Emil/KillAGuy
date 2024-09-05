public class Text(){
    public void Colour(string text, ConsoleColor colorname){
        Console.ForegroundColor = colorname;
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}