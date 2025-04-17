public class Solution 
{
    public int CalPoints(string[] operations)
    {
        List<int> record = new List<int>();

        int validCount = 0; // Keeps track of how many valid scores are in the list

        foreach (string op in operations)
        {
            if (op == "+")
            {
                int last = record[validCount - 1];
                int secondLast = record[validCount - 2];
                record.Add(last + secondLast);
                validCount++;
            }
            else if (op == "D")
            {
                int last = record[validCount - 1];
                record.Add(2 * last);
                validCount++;
            }
            else if (op == "C")
            {
                validCount--; // moves the valid count back
            }
            else
            {
                int num = int.Parse(op);
                record.Add(num);
                validCount++;
            }
        }

        int total = 0;
        for (int i = 0; i < validCount; i++)
        {
            total += record[i];
        }

        return total;
    }
}
