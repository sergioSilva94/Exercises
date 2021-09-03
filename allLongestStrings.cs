/*Given an array of strings, return another array containing 
all of its longest strings.*/
string[] allLongestStrings(string[] inputArray) 
{
    int longestString = 0;
    int countLongestStrings = 0;
    for(int i = 0; i < inputArray.Length; i++)
    {
        int currentLength = inputArray[i].Length;
        if(currentLength > longestString) 
        {
            longestString = currentLength;
            countLongestStrings = 0;
        }
        if(longestString == inputArray[i].Length)countLongestStrings ++;
    }
    
    string[] allLongestStrings = new string[countLongestStrings];
    int j = 0;
    for(int i = 0; i < inputArray.Length; i++)
    {
        if(longestString == inputArray[i].Length)
        {
            allLongestStrings[j] = inputArray[i];
            j++;
        }
    }    
    return allLongestStrings;
}