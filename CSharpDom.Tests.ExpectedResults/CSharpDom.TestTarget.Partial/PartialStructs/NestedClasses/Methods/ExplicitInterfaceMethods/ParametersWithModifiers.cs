namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithWithNestedClassWithExplicitInterfaceMethodWithParametersWithModifiers
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
