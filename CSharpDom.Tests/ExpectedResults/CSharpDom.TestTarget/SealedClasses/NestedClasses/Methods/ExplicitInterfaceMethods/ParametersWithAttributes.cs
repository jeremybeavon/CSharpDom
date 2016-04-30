namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedClassWithExplicitInterfaceWithMethodWithParametersWithAttributes
    {
        public class Class : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
