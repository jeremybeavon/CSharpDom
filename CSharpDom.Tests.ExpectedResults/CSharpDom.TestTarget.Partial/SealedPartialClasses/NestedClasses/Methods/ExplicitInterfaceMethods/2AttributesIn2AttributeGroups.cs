namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
    {
        public class Class : IInterfaceWithMethod
        {
            [Attribute1]
            [Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
