namespace CSharpDom.TestTarget.Classes.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedStructWithExplicitInterfaceMethodWith1Attribute
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
