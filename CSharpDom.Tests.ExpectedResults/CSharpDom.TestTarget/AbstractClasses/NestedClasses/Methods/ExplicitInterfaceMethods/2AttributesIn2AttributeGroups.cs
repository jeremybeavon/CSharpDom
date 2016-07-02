namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups
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
