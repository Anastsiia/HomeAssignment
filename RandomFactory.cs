public class RandomFactory<T>
{
    private Dictionary<int, T> indexDict;

    public RandomFactory(List<T> collectionToRandom)
    {
        this.TotalRecords = collectionToRandom.Count;
        this.SetIndexToAllItems(collectionToRandom);
    }

    public int TotalRecords { get; private set; }

    private void SetIndexToAllItems(List<T> collectionToRandom)
    {
        indexDict = new Dictionary<int, T>();

        for (int i = 0; i < TotalRecords; i++)
            indexDict.Add(i, collectionToRandom[i]);
    }

    public KeyValuePair<int, T> GetRandom()
    {
        Random rnd = new Random();
        int i = -1;

        while (!indexDict.ContainsKey(i))
            i = rnd.Next(0, TotalRecords);
        return new KeyValuePair<int, T>(i, indexDict[i]);
    }
    
    public void RemoveItem(int index)
    {
        this.indexDict.Remove(index);
    }
}

