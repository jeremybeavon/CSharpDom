namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
