/*Given two strings, find the number of common characters between them.*/
int commonCharacterCount(string s1, string s2) {
    //HashSet<char> seen = new HashSet<char>();
    int cuentaCharsRepetidos = 0;
    for(int i = 0; i < s1.Length; i++)
    {
        if(s2.Contains(s1[i]))
        {
           int indexCaps = s2.LastIndexOf(s1[i]);
           s2 = s2.Remove(indexCaps, 1);
           cuentaCharsRepetidos++;
        }
    }
    Console.Write(s2);
    return cuentaCharsRepetidos;
}