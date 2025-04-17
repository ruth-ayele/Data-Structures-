public class RecentCounter
{
    List<int> times;

    public RecentCounter()
    {
        times = new List<int>();
    }

    public int Ping(int t)
    {
        times.Add(t); // Add new ping
        int count = 0;

        // Counts how many pings are in the last 3000 ms
        for (int i = 0; i < times.Count; i++)
        {
            if (times[i] >= t - 3000)
            {
                count++;
            }
        }

        return count;
    }
}
