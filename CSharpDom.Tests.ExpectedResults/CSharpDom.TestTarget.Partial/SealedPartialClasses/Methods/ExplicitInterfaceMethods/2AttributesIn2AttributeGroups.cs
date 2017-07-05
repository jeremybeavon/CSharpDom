namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups : IInterfaceWithMethod
    {
        [Attribute1]
        [Attribute2]
        void IInterfaceWithMethod.Method()
        {
        }
    }
}
