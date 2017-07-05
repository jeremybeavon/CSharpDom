namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public class Class<T>
            where T : class
        {
        }
    }
}
