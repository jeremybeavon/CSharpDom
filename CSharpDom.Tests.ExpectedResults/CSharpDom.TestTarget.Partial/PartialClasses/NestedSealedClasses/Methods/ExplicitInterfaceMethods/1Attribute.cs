namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute
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
