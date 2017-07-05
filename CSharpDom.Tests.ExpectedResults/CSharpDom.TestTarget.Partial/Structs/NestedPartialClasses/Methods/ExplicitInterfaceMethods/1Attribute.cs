namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedPartialClassWithExplicitInterfaceMethodWith1Attribute
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
