namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup : IInterfaceWithMethod
    {
        [Attribute1, Attribute2]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
