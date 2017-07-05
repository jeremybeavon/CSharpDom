namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitInterfaceMethodWithParametersWithAttributes
    {
        public class Class : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
