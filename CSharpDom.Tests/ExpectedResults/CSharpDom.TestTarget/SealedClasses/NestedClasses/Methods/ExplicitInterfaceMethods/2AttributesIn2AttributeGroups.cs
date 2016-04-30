namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
    {
        public class Class : IInterfaceWithMethod
        {
            [Attribute1]
            [Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
