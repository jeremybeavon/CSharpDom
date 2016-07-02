namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
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
