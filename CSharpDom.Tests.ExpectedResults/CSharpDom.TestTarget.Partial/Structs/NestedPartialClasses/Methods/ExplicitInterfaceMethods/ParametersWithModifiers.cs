namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedPartialClassWithExplicitInterfaceMethodWithParametersWithModifiers
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
