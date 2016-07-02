namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedSealedClassWithExplicitInterfaceWithMethodWithParametersWithAttributes
    {
        public sealed class Class : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
