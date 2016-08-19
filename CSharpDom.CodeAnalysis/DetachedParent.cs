namespace CSharpDom.CodeAnalysis
{
    internal sealed class DetachedParent<TSyntax> : IHasChild<TSyntax>
    {
        public TSyntax Child { get; set; }
    }
}
