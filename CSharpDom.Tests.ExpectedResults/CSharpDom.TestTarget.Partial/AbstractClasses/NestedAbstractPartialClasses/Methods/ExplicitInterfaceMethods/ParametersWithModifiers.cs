namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithExplicitInterfaceMethodWithParametersWithModifiers
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
