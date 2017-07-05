namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class<T>
            where T : new()
        {
        }
    }
}
