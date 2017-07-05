namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiers
    {
        public struct Struct : IInterfaceWithMethodWithParametersWithModifiers
        {
            void IInterfaceWithMethodWithParametersWithModifiers.Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
