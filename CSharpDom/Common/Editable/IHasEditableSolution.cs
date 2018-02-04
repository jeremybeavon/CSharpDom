namespace CSharpDom.Common.Editable
{
    public interface IHasEditableSolution<TSolution> : IHasSolution<TSolution>
    {
        new TSolution Solution { get; set; }
    }
}