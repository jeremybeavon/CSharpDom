namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedAbstractClassWithExplicitInterfaceMethodWith1Attribute
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
