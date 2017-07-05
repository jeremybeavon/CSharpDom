namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup : IInterfaceWithMethod
    {
        [Attribute1, Attribute2]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
