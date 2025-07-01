string[] mArray = new string[8];
mArray[0] = "B123";
mArray[1] = "C234";
mArray[2] = "A345";
mArray[3] = "C15";
mArray[4] = "B177";
mArray[5] = "G3003";
mArray[6] = "C235";
mArray[7] = "B179";

foreach (string ids in mArray)
{
    if (ids.StartsWith("B"))
    {
        Console.WriteLine(ids);
    }
}