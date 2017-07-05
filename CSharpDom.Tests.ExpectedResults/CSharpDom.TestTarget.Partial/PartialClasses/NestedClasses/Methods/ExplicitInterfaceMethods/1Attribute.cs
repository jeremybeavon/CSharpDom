namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedClassWithExplicitInterfaceMethodWith1Attribute
    {
        public class Class : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
