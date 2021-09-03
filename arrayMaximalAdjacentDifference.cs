/*Given an array of integers, find the maximal absolute difference
 between any two of its adjacent elements.*/
int arrayMaximalAdjacentDifference(int[] inputArray) {
    int maxDif = 0;
    for(int i = 0; i < inputArray.Length-1; i++)
    {
        if(Math.Abs(inputArray[i] - inputArray[i+1]) > maxDif) maxDif = Math.Abs(inputArray[i] - inputArray[i+1]);
    }
    return maxDif;
}