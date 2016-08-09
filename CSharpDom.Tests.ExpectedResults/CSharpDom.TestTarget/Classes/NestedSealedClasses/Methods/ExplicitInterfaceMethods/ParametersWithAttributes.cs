namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithAttributes
    {
        public sealed class Class : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
