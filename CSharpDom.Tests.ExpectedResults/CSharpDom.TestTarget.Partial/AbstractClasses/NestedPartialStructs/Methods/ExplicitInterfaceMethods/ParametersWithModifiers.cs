namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiers
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
