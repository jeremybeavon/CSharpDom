namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
