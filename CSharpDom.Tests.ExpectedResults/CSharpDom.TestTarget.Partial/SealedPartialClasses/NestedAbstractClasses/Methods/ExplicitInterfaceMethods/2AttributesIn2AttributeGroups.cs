namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
