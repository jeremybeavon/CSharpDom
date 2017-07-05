namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedClasses
{
    public class ClassWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class<T>
            where T : IInterface
        {
        }
    }
}
