namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceMethodWithParametersWithModifiers : IInterfaceWithMethodWithParametersWithModifiers
    {
        void IInterfaceWithMethodWithParametersWithModifiers.Method(ref string parameter1, out string parameter2, params string[] parameters)
        {
            parameter2 = default(string);
        }
    }
}
