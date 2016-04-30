namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassWithNestedAbstractClassWithExplicitInterfaceWithMethodWithParametersWithAttributes
    {
        public abstract class Class : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
