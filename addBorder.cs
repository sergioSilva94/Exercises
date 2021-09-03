/*Given a rectangular matrix of characters, add a border of asterisks(*) to it.*/
string[] addBorder(string[] picture) {
    string[] borderedM = new string[picture.Length+2];
    borderedM[0] = new string('*', picture[0].Length+2);
    borderedM[borderedM.Length-1] = new string('*', picture[0].Length+2);
    int j = 0;
    for (int i = 1; i < borderedM.Length-1; i++)         
         {
             borderedM[i] = '*' + picture[j] + '*';
             j++;
         }
         return borderedM;
}
