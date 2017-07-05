namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithAttributes
    {
        public abstract class Class : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
