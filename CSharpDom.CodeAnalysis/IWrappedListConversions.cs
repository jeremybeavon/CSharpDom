namespace CSharpDom.CodeAnalysis
{
    internal interface IWrappedListConversions<TParent, TChild>
    {
        TChild ToChild(TParent parent);

        TParent ToParent(TChild child);
    }
}
