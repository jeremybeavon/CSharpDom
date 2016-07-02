namespace CSharpDom.TestTarget.SealedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed class SealedClassExplicitInterfaceWithMethodWithParametersWithAttributes : IInterfaceWithMethodWith2Parameters
    {
        void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
        {
        }
    }
}
