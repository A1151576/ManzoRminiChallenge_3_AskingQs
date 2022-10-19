/*
    Rafael Manzo
    Mini 3 push to github
    10/18/2022
    In this short C# program, we have revised an old project and then push the updates to GitHub.   
*/



Console.Clear();
bool playover = true;
while (playover)
{
    Console.WriteLine("Hello, my name is Computer, What is yours?");
    string username1 = Console.ReadLine();
    Console.WriteLine("Very nice to meet you " + username1);
    Console.WriteLine("What time did you wake up today ");
    string timeawoke1 = Console.ReadLine();
    Console.WriteLine("Not good " + username1 + " you should be waking up earlier than " + timeawoke1);
    Console.WriteLine("Would you like to play again? type no to quit or any key to play again.");
    string answer01 = Console.ReadLine();
    int x;
    bool n = int.TryParse(answer01, out x);
    if (answer01 == "no")
    {
        playover = false;
    }
}