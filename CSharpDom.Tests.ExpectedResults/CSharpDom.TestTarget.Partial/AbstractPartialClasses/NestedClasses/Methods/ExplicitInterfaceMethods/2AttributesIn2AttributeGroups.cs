namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
