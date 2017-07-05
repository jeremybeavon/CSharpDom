namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceMethodWithParametersWithModifiers : IInterfaceWithMethodWithParametersWithModifiers
    {
        void IInterfaceWithMethodWithParametersWithModifiers.Method(ref string parameter1, out string parameter2, params string[] parameters)
        {
            parameter2 = default(string);
        }
    }
}
