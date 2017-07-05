namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithAttributes
    {
        public struct Struct : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
