namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith1Attribute
    {
        public abstract class Class : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
