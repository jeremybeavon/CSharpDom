namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, new()
        {
        }
    }
}
