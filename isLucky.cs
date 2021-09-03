/*Ticket numbers usually consist of an even number of digits. A ticket number is considered 
lucky if the sum of the first half of the digits is equal to the sum of the second half.

Given a ticket number n, determine if it's lucky or not.*/
bool isLucky(int n) {
    int cuenta1 = 0;
    int cuenta2 = 0;
    char[] numberList = n.ToString().ToCharArray();
    for(int i = 0; i < numberList.Length; i++)
    {
        if(i < numberList.Length/2) cuenta1 = cuenta1 + numberList[i];
        else cuenta2 = cuenta2 + numberList[i];
    }
    
    return cuenta1 == cuenta2;
}