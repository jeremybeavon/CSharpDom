namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithAttributes
    {
        public abstract class Class : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
