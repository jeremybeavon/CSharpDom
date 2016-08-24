namespace CSharpDom.CodeAnalysis
{
    public interface IHasSyntax<TSyntax>
    {
        TSyntax Syntax { get; set; }
    }
}
