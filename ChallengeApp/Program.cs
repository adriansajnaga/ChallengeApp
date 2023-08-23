int number = 45666;
string numberToString = number.ToString();
char[] letters = numberToString.ToCharArray();
int existingLetter = 0;

for (int i = 0; i <= 9; i++) 
{
    foreach (char letter in letters)
    {
        int letterToInt = Convert.ToInt32(letter.ToString());
        if (letterToInt == i)
        {
            existingLetter++;
        }
    }
    Console.WriteLine($"{i} => {existingLetter}");
    existingLetter = 0;
}



//int letterToInt = letter - '0';   inna metoda zamiany cyfry zapisanej w kodzie ASCII na cyfrę