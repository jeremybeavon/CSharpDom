namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithAttributes
    {
        public sealed class Class : IInterfaceWithMethodWith2Parameters
        {
            void IInterfaceWithMethodWith2Parameters.Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
