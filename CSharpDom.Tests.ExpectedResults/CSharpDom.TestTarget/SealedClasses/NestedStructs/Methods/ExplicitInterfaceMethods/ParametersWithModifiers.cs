namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiers
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
