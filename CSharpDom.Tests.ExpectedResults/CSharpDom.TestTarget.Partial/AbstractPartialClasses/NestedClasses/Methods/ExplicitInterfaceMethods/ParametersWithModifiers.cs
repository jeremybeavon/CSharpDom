namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitInterfaceMethodWithParametersWithModifiers
    {
        public class Class : IInterfaceWithMethodWithParametersWithModifiers
        {
            void IInterfaceWithMethodWithParametersWithModifiers.Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
