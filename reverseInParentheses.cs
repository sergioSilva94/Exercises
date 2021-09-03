/*Write a function that reverses characters in (possibly nested) parentheses 
in the input string.

Input strings will always be well-formed with matching ()s.*/
string reverseInParentheses(string inputString) {
    int countParentesis = 0;
    for (int i = 0; i < inputString.Length; i++)
    {
        if(inputString[i] == '(') countParentesis++;
    }    
    for (int z = 0; z < countParentesis; z ++)
    {        
        int parentesisAbre = inputString.LastIndexOf('(');
        string substring1 = inputString.Substring(0, parentesisAbre+1);
        string inputString2 = inputString.Substring(parentesisAbre+1);        
        int parentesisCierra = inputString2.IndexOf(')');
        string substring2 = inputString2.Substring(0, parentesisCierra);
        string substring3 = inputString2.Substring(parentesisCierra);
        string rSubstring2 = "";
        for(int i = substring2.Length-1; i >= 0; i--)
        {
            rSubstring2 = rSubstring2 + substring2[i];
        }
        inputString = substring1.Remove(parentesisAbre, 1) + rSubstring2 + substring3.Remove(0, 1);
    }        
    return inputString;
}