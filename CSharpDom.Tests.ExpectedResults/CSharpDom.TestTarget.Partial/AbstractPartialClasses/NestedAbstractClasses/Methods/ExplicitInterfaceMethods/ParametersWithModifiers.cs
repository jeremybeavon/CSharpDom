namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithModifiers
    {
        public abstract class Class : IInterfaceWithMethodWithParametersWithModifiers
        {
            void IInterfaceWithMethodWithParametersWithModifiers.Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
