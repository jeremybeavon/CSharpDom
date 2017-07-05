namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithMethod
        {
            [Attribute1, Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
