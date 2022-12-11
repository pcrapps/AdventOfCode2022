//read in the files named elf in the elf directory
var elfs = new Dictionary<string, int>();
var numberofElves = 0;
foreach (var file in Directory.GetFiles("elf"))
{
    numberofElves++;
    var elfName = Path.GetFileNameWithoutExtension(file);
    var calories = File.ReadAllLines(file).ToList();
    var sumOfCalories = calories.Sum(x => int.Parse(x));
    elfs.Add(elfName, sumOfCalories);
}

var topElf = elfs.OrderByDescending(x => x.Value).First();

Console.WriteLine($"The top elf is {topElf.Key} with {topElf.Value} calories");
