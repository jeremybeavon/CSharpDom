namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, new()
        {
        }
    }
}
