namespace AdventOfCode.Y2023.Day01;

[ProblemName("Trebuchet?!")]
class Solution : Solver
{
    public object PartOne(string[] input)
    {
        int sum = 0;

        foreach (string line in input)
        {
            string firstNumber = "";
            string lastNumber = "";

            for (int i = 0; i < line.Length; i++)
            {
                if (firstNumber == "" && char.IsNumber(line[i]))
                {
                    firstNumber = line[i].ToString();
                } 
                int reverseIndex = line.Length - 1 - i;
                if (lastNumber == "" && char.IsNumber(line[reverseIndex]))
                {
                    lastNumber = line[reverseIndex].ToString();
                }
            }

            sum += int.TryParse(firstNumber + lastNumber, out int number) ? number : 0;
        }

        return sum;
    }

    public object PartTwo(string[] input)
    {
        int sum = 0;

        foreach (string line in input)
        {
            string firstNumber = "";
            string lastNumber = "";

            for (int i = 0; i < line.Length; i++)
            {
                if (firstNumber == "")
                {
                    TryParseWrittenNumber(line, i, false, out firstNumber);

                    if (char.IsNumber(line[i]))
                    {
                        firstNumber = line[i].ToString();
                    }
                    else
                    {
                        TryParseWrittenNumber(line, i, false, out firstNumber);
                    }
                }
                int reverseIndex = line.Length - 1 - i;
                if (lastNumber == "")
                {
                    if (char.IsNumber(line[reverseIndex]))
                    {
                        lastNumber = line[reverseIndex].ToString();
                    }
                    else
                    {
                        TryParseWrittenNumber(line, reverseIndex, true, out lastNumber);
                    }
                }
            }

            sum += int.TryParse(firstNumber + lastNumber, out int number) ? number : 0;
        }

        return sum;
    }

    private bool TryParseWrittenNumber(string line, int startIndex, bool reversed, out string number)
    {
        number = "";
        bool hasRoomFor3 = line.Length >= startIndex + 3;
        bool hasReversedRoomFor3 = reversed && startIndex - 3 >= -1;
        bool hasRoomFor4 = line.Length >= startIndex + 4;
        bool hasReversedRoomFor4 = reversed && startIndex - 4 >= -1;
        bool hasRoomFor5 = line.Length >= startIndex + 5;
        bool hasReversedRoomFor5 = reversed && startIndex - 5 >= -1;

        if (hasRoomFor3)
        {
            number = ParseWritten3LetterNumber(line.Substring(startIndex, 3));
            if (number != "")
            {
                return true;
            }
        }
        if (hasReversedRoomFor3)
        {
            number = ParseWritten3LetterNumber(line.Substring(startIndex - (3 - 1), 3));
            if (number != "")
            {
                return true;
            }
        }
        if (hasRoomFor4)
        {
            number = ParseWritten4LetterNumber(line.Substring(startIndex, 4));
            if (number != "")
            {
                return true;
            }
        }
        if (hasReversedRoomFor4)
        {
            number = ParseWritten4LetterNumber(line.Substring(startIndex - (4 - 1), 4));
            if (number != "")
            {
                return true;
            }
        }
        if (hasRoomFor5)
        {
            number = ParseWritten5LetterNumber(line.Substring(startIndex, 5));
            if (number != "")
            {
                return true;
            }
        }
        if (hasReversedRoomFor5)
        {
            number = ParseWritten5LetterNumber(line.Substring(startIndex - (5 - 1), 5));
            if (number != "")
            {
                return true;
            }
        }

        return false;
    }

    private string ParseWritten3LetterNumber(string line)
    {
        return line switch
        {
            "one" => "1",
            "two" => "2",
            "six" => "6",
            _ => ""
        };
    }

    private string ParseWritten4LetterNumber(string line)
    {
        return line switch
        {
            "four" => "4",
            "five" => "5",
            "nine" => "9",
            _ => ""
        };
    }

    private string ParseWritten5LetterNumber(string line)
    {
        return line switch
        {
            "three" => "3",
            "seven" => "7",
            "eight" => "8",
            _ => ""
        };
    }
}
