namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedAbstractPartialClassWithExplicitInterfaceMethodWithParametersWithModifiers
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
