namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
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
