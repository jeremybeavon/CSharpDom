namespace CSharpDom.TestTarget.AbstractClasses.Methods.ExplicitInterfaceMethods
{
    public abstract class AbstractClassExplicitInterfaceWithMethodWithParametersWithAttributes : IInterfaceWithMethodWith2Parameters
    {
        void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
        {
        }
    }
}
