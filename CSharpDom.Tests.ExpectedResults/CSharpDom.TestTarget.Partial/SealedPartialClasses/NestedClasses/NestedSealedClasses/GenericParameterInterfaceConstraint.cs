namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
