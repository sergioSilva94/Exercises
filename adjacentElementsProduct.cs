/*Given an array of integers, find the pair of adjacent elements
 that has the largest product and return that product.*/
 int adjacentElementsProduct(int[] inputArray) {
    int maxProductTemp = 0;
    int maxProduct = inputArray[0] * inputArray[1];
    for (int i = 1; i < inputArray.Length - 1; i++) 
    {
        maxProductTemp = inputArray[i] * inputArray[i+1];
        if(maxProductTemp > maxProduct)
        {
            maxProduct = maxProductTemp;
        }
    }
    return maxProduct;
}