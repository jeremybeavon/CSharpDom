namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public static partial class StaticPartialClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
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
