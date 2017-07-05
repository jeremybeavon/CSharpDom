namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
