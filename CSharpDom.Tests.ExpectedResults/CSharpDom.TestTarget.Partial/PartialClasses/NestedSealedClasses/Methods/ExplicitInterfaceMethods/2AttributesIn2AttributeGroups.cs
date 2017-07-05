namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
