namespace CSharpDom.TestTarget.Interfaces.Methods
{
    public interface IInterfaceWithMethodWithParametersWithModifiers
    {
        void Method(ref string parameter1, out string parameter2, params string[] parameters);
    }
}
