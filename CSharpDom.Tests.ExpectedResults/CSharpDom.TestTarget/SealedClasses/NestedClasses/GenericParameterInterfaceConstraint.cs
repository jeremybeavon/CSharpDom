namespace CSharpDom.TestTarget.SealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public class Class<T>
            where T : IInterface
        {
        }
    }
}
