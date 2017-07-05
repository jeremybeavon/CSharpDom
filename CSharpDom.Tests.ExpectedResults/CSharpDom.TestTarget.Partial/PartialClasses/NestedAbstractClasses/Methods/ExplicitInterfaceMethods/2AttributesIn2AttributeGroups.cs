namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
