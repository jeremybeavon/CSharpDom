namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute
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
