namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
