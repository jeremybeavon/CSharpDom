namespace CSharpDom.CodeAnalysis
{
    internal sealed class SimpleChildCollection<TParentSyntax, TChild, TSyntax, TSyntaxSubClass> :
        IChildCollection<TParentSyntax, TChild, TSyntaxSubClass>
        where TSyntaxSubClass : TSyntax
    {
        private readonly IChildCollection<TParentSyntax, TChild, TSyntax> childCollection;

        public SimpleChildCollection(IChildCollection<TParentSyntax, TChild, TSyntax> childCollection)
        {
            this.childCollection = childCollection;
        }

        public TSyntaxSubClass GetChild(TChild child)
        {
            return (TSyntaxSubClass)childCollection.GetChild(child);
        }

        public TParentSyntax SetChild(TChild child, TSyntaxSubClass syntax)
        {
            return childCollection.SetChild(child, syntax);
        }
    }
}
