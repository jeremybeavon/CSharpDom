namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithExplicitInterfaceMethodWithParametersWithModifiers
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
