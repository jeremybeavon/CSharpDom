namespace CSharpDom.CodeAnalysis
{
    internal interface IChildSyntaxListConversions<TParentSyntax, TChildList>
    {
        TChildList GetList(TParentSyntax syntax);

        TParentSyntax CreateList(TParentSyntax parentSyntax, TChildList childSyntax);
    }
}
