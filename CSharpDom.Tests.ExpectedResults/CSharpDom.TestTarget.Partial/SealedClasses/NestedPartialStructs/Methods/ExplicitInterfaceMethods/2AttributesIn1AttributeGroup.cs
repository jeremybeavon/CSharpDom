namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
    {
        public struct Struct : IInterfaceWithMethod
        {
            [Attribute1, Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
