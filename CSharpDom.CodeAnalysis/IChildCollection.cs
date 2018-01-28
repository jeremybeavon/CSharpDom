namespace CSharpDom.CodeAnalysis
{
    public interface IChildCollection<TParentSyntax, TChild, TSyntax> //: IList<TChild>
    {
        TSyntax GetChild(TChild child);

        TParentSyntax SetChild(TChild child, TSyntax syntax);
    }
}
