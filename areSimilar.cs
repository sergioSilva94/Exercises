/*Two arrays are called similar if one can be obtained from another by swapping at most one pair of elements in one of the arrays.

Given two arrays a and b, check whether they are similar.*/
bool areSimilar(int[] a, int[] b) {
    int index1 = -1;
    int index2 = -1;
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] != b[i] && index1 == -1) index1 = i;
        else if(a[i] != b[i] && index1 != -1) 
        {
            index2 = i;
            break;
        }        
    }
    if(index1 == -1 && index2 == -1) return true;
    int value1 = b[index1];
    int value2 = b[index2];
    b[index1] = value2;
    b[index2] = value1;
    
    return a.SequenceEqual(b);
}