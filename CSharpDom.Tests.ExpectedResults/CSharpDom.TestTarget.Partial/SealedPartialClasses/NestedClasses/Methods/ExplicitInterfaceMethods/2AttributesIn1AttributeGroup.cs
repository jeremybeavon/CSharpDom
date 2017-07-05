namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
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
