namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute
    {
        public sealed class Class : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
