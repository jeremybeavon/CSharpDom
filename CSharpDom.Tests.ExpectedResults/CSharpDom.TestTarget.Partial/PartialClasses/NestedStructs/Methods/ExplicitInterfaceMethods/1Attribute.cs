namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedStructWithExplicitInterfaceMethodWith1Attribute
    {
        public struct Struct : IInterfaceWithMethod
        {
            [Attribute1]
            void IInterfaceWithMethod.Method()
            {
            }
        }
    }
}
