Console.Clear();
void FillingArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
string[] sourceArray = { "123", "Length", "23", "098", "hello", "res", "world", "yes", "dzo", ":-)"};
string[] resultingArray = new string[sourceArray.Length];
FillingArray(sourceArray, resultingArray);
resultingArray = resultingArray.Where(x => x != null).ToArray();
Console.WriteLine($"\n" + '[' + string.Join(", ", sourceArray) + ("] -> [") + string.Join(", ", resultingArray) + ']' + "\n\n");