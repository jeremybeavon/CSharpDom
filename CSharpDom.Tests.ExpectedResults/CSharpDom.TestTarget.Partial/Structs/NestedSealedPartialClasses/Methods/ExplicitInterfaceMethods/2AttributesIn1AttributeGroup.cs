namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedSealedPartialClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
    {
        public sealed class Class : IInterfaceWithMethod
        {
            [Attribute1, Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
