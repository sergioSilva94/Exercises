/*Some people are standing in a row in a park. There are trees between them which cannot
 be moved. Your task is to rearrange the people by their heights in a non-descending order 
 without moving the trees. 
People can be very tall!*/
int[] sortByHeight(int[] a) {
    List<int> heights = new List<int>();
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] > -1)
        {
            heights.Add(a[i]);
        }
    }
    heights.Sort();
    int j = 0;
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] > -1)
        {
            a[i] = heights[j];
            j++;
        }
    }
    return a;
}