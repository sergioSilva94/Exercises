/*You are given an array of integers. On each move you are allowed to 
increase exactly one of its element by one. Find the minimal number 
of moves required to obtain a strictly increasing sequence from the input.*/
int arrayChange(int[] inputArray) {
    bool check = false;
    bool check2 = true;
    int count = 0;
    while(check == false)
    {
        check2 = true;
        for(int i = 0; i < inputArray.Length-1; i++)
        {
            if(inputArray[i] >= inputArray[i+1])
            {
                inputArray[i+1]++;
                count++;
                if(inputArray[i] >= inputArray[i+1]) check2 = false;
            }
        }
        if(check2 == true) check = true;
    }
    return count;
}