namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedClassWithExplicitInterfaceMethodWithParametersWithModifiers
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
