namespace CSharpDom.CodeAnalysis
{
    internal interface IHasNode<TSyntax>
        where TSyntax : class
    {
        INode<TSyntax> Node { get; }
    }
}
