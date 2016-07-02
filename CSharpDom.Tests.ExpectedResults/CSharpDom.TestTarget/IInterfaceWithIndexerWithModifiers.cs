namespace CSharpDom.TestTarget
{
    public interface IInterfaceWithIndexerWithModifiers
    {
        string this[params string[] descriptions] { set; }
    }
}
