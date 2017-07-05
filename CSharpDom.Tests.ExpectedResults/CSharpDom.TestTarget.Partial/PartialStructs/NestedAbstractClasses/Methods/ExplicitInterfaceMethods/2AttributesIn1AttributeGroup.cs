namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
    {
        public abstract class Class : IInterfaceWithMethod
        {
            [Attribute1, Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
