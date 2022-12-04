// DAY 2
// PART 1

// read file
var input = System.IO.File.ReadAllText(@"..\..\..\input.txt").Trim();
Console.WriteLine("INPUT:\n" + input);
var pairs = input.Split('\n');

var points = 0;
foreach (var pair in pairs)
{
    var match = pair.Split(' ');
    var opponent = match[0];
    var player = match[1];
    // opponent: A=rock B=paper C=scissors
    // player: X=rock,1 Y=paper,2 Z=scissors,3
    switch(player)
    {
        case "X":
            points += 1;
            switch(opponent)
            {
                case "A":
                    points += 3;
                    break;
                case "C":
                    points += 6;
                    break;
            }
            break;
        case "Y":
            points += 2;
            switch (opponent)
            {
                case "B":
                    points += 3;
                    break;
                case "A":
                    points += 6;
                    break;
            }
            break;
        case "Z":
            points += 3;
            switch (opponent)
            {
                case "C":
                    points += 3;
                    break;
                case "B":
                    points += 6;
                    break;
            }
            break;
    }
}
Console.WriteLine("POINTS:\n" + points);

// PART 2
var newPoints = 0;
foreach (var pair in pairs)
{
    var match = pair.Split(' ');
    var opponent = match[0];
    var outcome = match[1];
    // opponent: A=rock,1 B=paper,2 C=scissors,3
    // outcome: X=lose Y=draw Z=win
    switch (outcome)
    {
        case "X":
            switch (opponent)
            {
                case "A":
                    newPoints += 3;
                    break;
                case "B":
                    newPoints += 1;
                    break;
                case "C":
                    newPoints += 2;
                    break;
            }
            break;
        case "Y":
            newPoints += 3;
            switch (opponent)
            {
                case "A":
                    newPoints += 1;
                    break;
                case "B":
                    newPoints += 2;
                    break;
                case "C":
                    newPoints += 3;
                    break;
            }
            break;
        case "Z":
            newPoints += 6;
            switch (opponent)
            {
                case "A":
                    newPoints += 2;
                    break;
                case "B":
                    newPoints += 3;
                    break;
                case "C":
                    newPoints += 1;
                    break;
            }
            break;
    }
}
Console.WriteLine("NEW POINTS:\n" + newPoints);
