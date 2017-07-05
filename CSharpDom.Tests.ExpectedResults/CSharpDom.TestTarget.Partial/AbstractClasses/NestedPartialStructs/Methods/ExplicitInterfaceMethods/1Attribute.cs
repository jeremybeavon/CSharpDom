namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedStructWithExplicitInterfaceMethodWith1Attribute
    {
        public struct Struct : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
