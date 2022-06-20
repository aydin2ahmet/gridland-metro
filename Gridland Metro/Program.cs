List<List<int>> track = new List<List<int>>() { new List<int>() { 2, 2, 3 }, new List<int>() { 3, 1, 4 }, new List<int>() { 4, 4, 4 }};

var result = gridlandMetro(4, 4, 3, track);

Console.WriteLine(result);

long gridlandMetro(int n, int m, int k, List<List<int>> track)
{
    Dictionary<int, List<List<int>>> trackDict = new Dictionary<int, List<List<int>>>();

    foreach (var i in track)
    {
        if (!trackDict.ContainsKey(i[0]))
            trackDict[i[0]] = new List<List<int>>() { new List<int>() { i[1], i[2] } };
        else
        {
            var currentRowTrackList = trackDict[i[0]];
            var c1 = i[1];
            var c2 = i[2];

            for (int j = 0; j < currentRowTrackList.Count(); j++)
            {
                if (c2 < currentRowTrackList[j][0] || c1 > currentRowTrackList[j][1])
                    continue;

                c1 = c1 < currentRowTrackList[j][0] ? c1 : currentRowTrackList[j][0];
                c2 = c2 > currentRowTrackList[j][1] ? c2 : currentRowTrackList[j][1];

                currentRowTrackList.RemoveAt(j);
                j -= 1;
            }

            trackDict[i[0]].Add(new List<int>() { c1, c2 });
        }
    }

    long lamppostsCount = 0;

    foreach (var i in trackDict)
    {
        int columnTrack = m;

        foreach (var j in i.Value)
            columnTrack -= (j[1] - j[0] + 1);

        lamppostsCount += columnTrack;
    }

    return lamppostsCount + ((long)n - trackDict.Count()) * m;
}