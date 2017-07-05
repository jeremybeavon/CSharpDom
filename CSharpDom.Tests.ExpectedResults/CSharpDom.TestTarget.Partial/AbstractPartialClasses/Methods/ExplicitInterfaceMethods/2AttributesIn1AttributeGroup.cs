namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup : IInterfaceWithMethod
    {
        [Attribute1, Attribute2]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
