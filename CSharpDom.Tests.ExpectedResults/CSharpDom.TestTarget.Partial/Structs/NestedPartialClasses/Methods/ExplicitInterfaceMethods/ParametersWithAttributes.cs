namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods.ExplicitInterfaceMethods
{
    public struct StructWithNestedPartialClassWithExplicitInterfaceMethodWithParametersWithAttributes
    {
        public class Class : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
