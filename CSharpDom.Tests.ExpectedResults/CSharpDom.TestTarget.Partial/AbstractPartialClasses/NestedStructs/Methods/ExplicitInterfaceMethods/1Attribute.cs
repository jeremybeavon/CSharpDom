namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithNestedStructWithExplicitInterfaceMethodWith1Attribute
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
