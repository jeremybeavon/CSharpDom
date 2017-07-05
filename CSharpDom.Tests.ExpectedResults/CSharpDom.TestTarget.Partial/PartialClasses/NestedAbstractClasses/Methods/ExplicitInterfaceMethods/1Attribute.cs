namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1Attribute
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
