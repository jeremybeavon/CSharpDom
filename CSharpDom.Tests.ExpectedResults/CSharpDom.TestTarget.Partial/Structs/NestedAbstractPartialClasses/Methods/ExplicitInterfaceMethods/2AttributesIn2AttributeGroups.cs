namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
    {
        public abstract class Class : IInterfaceWithMethod
        {
            [Attribute1]
            [Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
