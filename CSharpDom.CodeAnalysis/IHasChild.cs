namespace CSharpDom.CodeAnalysis
{
    internal interface IHasChild<TSyntax>
    {
        TSyntax Child { get; set; }
    }
}
