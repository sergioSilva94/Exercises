/*Ratiorg got statues of different sizes as a present from CodeMaster for his
 birthday, each statue having an non-negative integer size. Since he likes
  to make things perfect, he wants to arrange them from smallest to largest so 
  that each statue will be bigger than the previous one exactly by 1. 
  He may need some additional statues to be able to accomplish that.
 Help him figure out the minimum number of additional statues needed.*/
 int makeArrayConsecutive2(int[] statues) {
    int c = 0;
    if(statues.Length >= 1 && statues.Length <= 10)
    {        
        int min = 10;
        int max = 1;
        for(int i = 0; i < statues.Length; i++){
            if(statues[i] < min) min = statues[i];
            if(statues[i] > max) max = statues[i];
        }
        for(int j = min + 1; j < max; j++)
        {
            for(int i = 0; i < statues.Length; i++)
            {
                if(j == statues[i]) break;
                if(i == statues.Length - 1) c++;
            }
        }
    }
    return c;
}