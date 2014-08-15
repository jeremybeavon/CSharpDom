namespace CSharpDom.Common
{
    public interface IHasSyntax<TSyntax>
    {
        TSyntax Syntax { get; }
    }
}
