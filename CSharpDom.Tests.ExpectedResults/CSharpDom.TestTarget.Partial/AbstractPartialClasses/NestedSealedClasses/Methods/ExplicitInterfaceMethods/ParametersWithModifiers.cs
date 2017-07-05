namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiers
    {
        public sealed class Class : IInterfaceWithMethodWithParametersWithModifiers
        {
            void IInterfaceWithMethodWithParametersWithModifiers.Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
