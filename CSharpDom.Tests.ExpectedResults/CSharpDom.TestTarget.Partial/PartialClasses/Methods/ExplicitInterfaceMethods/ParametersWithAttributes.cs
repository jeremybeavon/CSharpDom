namespace CSharpDom.TestTarget.Partial.PartialClasses.Methods.ExplicitInterfaceMethods
{
    public partial class PartialClassWithExplicitInterfaceMethodWithParametersWithAttributes : IInterfaceWithMethodWith2Parameters
    {
        void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
        {
        }
    }
}
