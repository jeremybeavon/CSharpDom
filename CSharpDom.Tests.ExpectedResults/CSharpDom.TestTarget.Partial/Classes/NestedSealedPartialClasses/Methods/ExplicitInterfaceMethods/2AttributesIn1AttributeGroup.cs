namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedSealedPartialClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
    {
        public sealed class Class : IInterfaceWithMethod
        {
            [Attribute1, Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
