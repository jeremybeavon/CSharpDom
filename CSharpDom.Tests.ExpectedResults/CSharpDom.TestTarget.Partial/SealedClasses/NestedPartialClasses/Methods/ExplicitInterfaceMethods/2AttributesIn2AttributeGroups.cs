namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedPartialClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
