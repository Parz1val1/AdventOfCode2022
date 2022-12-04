// read file
var input = System.IO.File.ReadAllText(@"..\..\..\Day1\input.txt").Trim();
Console.WriteLine("INPUT:\n" + input);

// split into groups
var numGroups = input.Split("\n\n");
Console.WriteLine("NUM GROUPS:\n" + numGroups.Length);

// get sum of groups
var sumGroups = new List<int>();
foreach (var group in numGroups)
{
    var calories = group.Split("\n");
    var calorySum = 0;
    foreach (var cal in calories)
    {
        calorySum += Int32.Parse(cal.Trim());
    }
    sumGroups.Add(calorySum);
}

// get max in collection
var max = sumGroups.Max();
Console.WriteLine("SUM GROUPS:\n" + max);
return max;