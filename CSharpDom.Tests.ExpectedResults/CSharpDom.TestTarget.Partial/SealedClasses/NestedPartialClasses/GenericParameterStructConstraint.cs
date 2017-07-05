namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public class Class<T>
            where T : struct
        {
        }
    }
}
