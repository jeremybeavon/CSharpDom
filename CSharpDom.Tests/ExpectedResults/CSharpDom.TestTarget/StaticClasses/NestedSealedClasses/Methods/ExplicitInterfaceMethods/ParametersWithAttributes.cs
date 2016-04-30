namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public static class StaticClassWithNestedSealedClassWithExplicitInterfaceWithMethodWithParametersWithAttributes
    {
        public sealed class Class : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
