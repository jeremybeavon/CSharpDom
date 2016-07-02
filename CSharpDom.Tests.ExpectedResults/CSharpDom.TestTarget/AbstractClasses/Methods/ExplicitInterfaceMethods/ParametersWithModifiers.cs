namespace CSharpDom.TestTarget.AbstractClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithExplicitInterfaceMethodWithParametersWithModifiers : IInterfaceWithMethodWithParametersWithModifiers
    {
        void IInterfaceWithMethodWithParametersWithModifiers.Method(ref string parameter1, out string parameter2, params string[] parameters)
        {
            parameter2 = default(string);
        }
    }
}
