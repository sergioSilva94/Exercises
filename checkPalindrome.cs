/*Given the string, check if it is a palindrome.*/
bool checkPalindrome(string inputString) {
    bool check = true;
    if ( inputString != null && inputString.Length < Math.Pow(10,5))
    {
        char[] normalArray = inputString.ToCharArray();
        char[] reversedArray = new char[normalArray.Length];
        int j = normalArray.Length - 1;
        for(int i = 0; i < normalArray.Length; i++)
        {
            reversedArray[j] = normalArray[i];
            j--;
        }
        for(int i = 0; i < normalArray.Length; i++)
        {
            if(reversedArray[i] != normalArray[i])
            {
                check = false;
                break;
            }
        }
    }
    return check;
}