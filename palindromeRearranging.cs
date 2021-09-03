/*Given a string, find out if its 
characters can be rearranged to form a palindrome.*/
bool palindromeRearranging(string inputString) {
    int[] counting = new int[26];
    int cuentaImpares = 0;
    for(int i = 0; i < inputString.Length; i++)
    {
        char c = inputString[i];
        counting[c - 'a']++;
    }
    for(int i = 0; i < counting.Length; i++)
    {
        if(counting[i] > 0 && counting[i] % 2 == 1)
        {
            cuentaImpares++;
            if (cuentaImpares > 1) return false;
        }
    }
    return true;
}
