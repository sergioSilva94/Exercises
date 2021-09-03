/*Given a sequence of integers as an array, determine whether it 
is possible to obtain a strictly increasing sequence by removing 
no more than one element from the array.*/
//solución no viable
    /*bool check = true;
    int index1 = 0;
    int index2 = 0;    
    
        for(int i = 0; i < sequence.Length; i++)
        {          
            check = true;  
            for(int j = 0; j < sequence.Length - 1; j++)
            {
                if(i != j)
                {
                    index1 = j;
                    index2 = j+1;
                    if ( i == index2 && j != sequence.Length -2)
                    {
                        index2 = j+2;      
                    }
                    
                    if(j == sequence.Length -2 && i == sequence.Length -1)
                    {
                        break;
                    }
                    
                    if(sequence[index2] <= sequence[index1])
                    {
                            check = false;
                            break;
                    }                    
                }
            }
            if(check == true)
            {
                return check;
            }
        }
    
    return check;*/
    
    ///////Primera solución viable//////
    bool check = true;
    int removeValue = 0;
    if(sequence.Length == 2) return check;
    for(int i = 0; i < sequence.Length-1; i++)
    {
        if(sequence[i] > sequence[i+1])
        {
            removeValue = i;
            break;
        }
    }
    
    int[] betterSequence = new int[sequence.Length-1];
    int j = 0;
    for(int i = 0; i < sequence.Length; i++)
    {
        if(i == removeValue)
        {
           i++;            
        }        
        betterSequence[j] = sequence[i];
        j++;
    }
        
    for(int i = 0; i < betterSequence.Length-1; i++)
    {
        if(betterSequence[i] >= betterSequence[i+1]) check = false;
    }
    
    if(check ==  true) return check;
    
        check = true;
        betterSequence[removeValue] = sequence[removeValue];
        for(int i = 0; i < betterSequence.Length-1; i++)
        {
            if(betterSequence[i] >= betterSequence[i+1]) check = false;
        }
        return check;


    //////////////