Console.WriteLine("first word");
string word1 = Console.ReadLine();

Console.WriteLine("second word");
string word2 = Console.ReadLine();

bool status = false;

for (int i = 0; i < word1.Length; i++)
{
    for (int j = 0; j < word2.Length; j++)
    {
        if (word1[i + j] != word2[j])
        {
            status = false;
            break;
        }
        else if (word1[i + j] == word2[j])
        {
            status = true;
        }
    }
    if (status)
    {
        Console.WriteLine("substring");
        break;
    }

}

if (!status)
{
    Console.WriteLine("not substring");
}