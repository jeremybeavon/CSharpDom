namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedAbstractPartialClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
