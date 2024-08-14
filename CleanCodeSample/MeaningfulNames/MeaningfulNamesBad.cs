namespace CleanCodeSamples.MeaningfulNamesBad;

public class MeaningfulNamesBad
{
    public void DoIt()
    {
        var x = GetData();
        var y = x.Where(z => z.IsActive).ToList();
        foreach (var a in y)
        {
            if (a.Amount > 100)
            {
                Process(a);
            }
        }
    }

    private List<Item> GetData()
    {
        // Imagine this method fetches a list of items from a database.
        return new List<Item>();
    }

    private void Process(Item i)
    {
        // Imagine this method processes an item in some way.
    }

}