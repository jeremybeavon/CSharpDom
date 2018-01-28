namespace CSharpDom.CodeAnalysis
{
    internal interface IImmutableList<TList, TItem>
    {
        TList Add(TList list, TItem item);

        TList Insert(TList list, int index, TItem item);

        TList Remove(TList list, TItem item);

        TList RemoveAt(TList list, int index);

        TList Replace(TList list, TItem oldItem, TItem newItem);
    }
}
