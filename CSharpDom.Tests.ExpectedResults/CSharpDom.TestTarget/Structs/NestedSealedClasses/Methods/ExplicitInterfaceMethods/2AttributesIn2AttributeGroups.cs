namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
    {
        public sealed class Class : IInterfaceWithMethod
        {
            [Attribute1]
            [Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
