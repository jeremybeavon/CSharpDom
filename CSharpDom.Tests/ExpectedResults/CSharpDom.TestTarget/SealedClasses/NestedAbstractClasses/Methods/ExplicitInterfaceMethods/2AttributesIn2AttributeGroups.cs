namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
    {
        public abstract class Class : IInterfaceWithMethod
        {
            [Attribute1]
            [Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
