namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
