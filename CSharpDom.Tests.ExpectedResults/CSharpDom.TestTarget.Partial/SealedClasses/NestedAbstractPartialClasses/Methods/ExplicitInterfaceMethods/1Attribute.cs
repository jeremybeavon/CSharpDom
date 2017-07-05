namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith1Attribute
    {
        public abstract class Class : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
