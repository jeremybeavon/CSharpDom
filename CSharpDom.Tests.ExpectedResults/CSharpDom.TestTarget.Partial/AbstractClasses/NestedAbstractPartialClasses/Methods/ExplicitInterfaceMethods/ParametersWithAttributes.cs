namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithExplicitInterfaceMethodWithParametersWithAttributes
    {
        public abstract class Class : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
