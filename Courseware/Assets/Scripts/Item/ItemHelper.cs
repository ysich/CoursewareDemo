public static class ItemHelper
{
    public static bool IsSameID(this ItemBase curItem, ItemBase targetItem)
    {
        return curItem.id == targetItem.id;
    }
}