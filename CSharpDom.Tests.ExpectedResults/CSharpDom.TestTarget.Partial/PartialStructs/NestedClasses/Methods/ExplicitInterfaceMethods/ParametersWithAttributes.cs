namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public partial struct PartialStructWithWithNestedClassWithExplicitInterfaceMethodWithParametersWithAttributes
    {
        public class Class : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
