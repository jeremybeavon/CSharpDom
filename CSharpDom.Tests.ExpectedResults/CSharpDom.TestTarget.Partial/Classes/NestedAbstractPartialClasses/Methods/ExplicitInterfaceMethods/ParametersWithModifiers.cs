namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedAbstractPartialClassWithExplicitInterfaceMethodWithParametersWithModifiers
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
