namespace CleanCodeSamples.MeaningfulNamesBad;

public class MeaningfulNames
{
    public void ProcessHighValueActiveItems()
    {
        var items = FetchAllItems();
        var activeItems = items.Where(item => item.IsActive).ToList();

        foreach (var item in activeItems)
        {
            if (item.Amount > 100)
            {
                ProcessItem(item);
            }
        }
    }

    private List<Item> FetchAllItems()
    {
        // This method fetches a list of items from a database.
        return [];
    }

    private void ProcessItem(Item item)
    {
        // This method processes a high-value active item.
    }

}