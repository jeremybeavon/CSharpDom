namespace CSharpDom.TestTarget.SealedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithExplicitInterfaceMethodWithParametersWithModifiers : IInterfaceWithMethodWithParametersWithModifiers
    {
        void IInterfaceWithMethodWithParametersWithModifiers.Method(ref string parameter1, out string parameter2, params string[] parameters)
        {
            parameter2 = default(string);
        }
    }
}
