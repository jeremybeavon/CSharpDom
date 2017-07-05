namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups : IInterfaceWithMethod
    {
        [Attribute1]
        [Attribute2]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
