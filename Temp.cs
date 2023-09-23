if (File.Exists(fileName))
{
    using (var reader = File.OpenText(fileName))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            float.TryParse(line, out float point);
            statistics.Max = Math.Max(statistics.Max, point);
            statistics.Min = Math.Min(statistics.Min, point);
            statistics.Avg += point;
            count++;
        }
    }
}
else
{
    throw new Exception($"The File: {fileName} - not exist");
}



in memory
            public override Statistics GetStatistics()
{
    var statistics = new Statistics();

    statistics.Max = float.MinValue;
    statistics.Min = float.MaxValue;
    statistics.Avg = 0;

    foreach (var point in this.listOfPoints)
    {
        statistics.Max = Math.Max(statistics.Max, point);
        statistics.Min = Math.Min(statistics.Min, point);
        statistics.Avg += point;
    }
    statistics.Avg /= this.listOfPoints.Count;
    statistics.Count = this.listOfPoints.Count;
    switch (statistics.Avg)
    {
        case var a when a > 80:
            statistics.AvgLetter = 'A';
            break;
        case var a when a > 60:
            statistics.AvgLetter = 'B';
            break;
        case var a when a > 40:
            statistics.AvgLetter = 'C';
            break;
        case var a when a > 20:
            statistics.AvgLetter = 'D';
            break;
        default:
            statistics.AvgLetter = 'E';
            break;
    }
    return statistics;
}