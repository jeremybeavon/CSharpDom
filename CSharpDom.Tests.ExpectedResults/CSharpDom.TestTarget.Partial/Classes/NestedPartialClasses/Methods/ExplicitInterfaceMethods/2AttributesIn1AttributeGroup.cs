namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedPartialClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup
    {
        public class Class : IInterfaceWithMethod
        {
            [Attribute1, Attribute2]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
