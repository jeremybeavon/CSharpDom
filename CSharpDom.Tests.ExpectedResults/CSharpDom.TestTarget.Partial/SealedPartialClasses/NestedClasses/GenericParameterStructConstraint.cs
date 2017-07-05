namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithGenericParameterStructConstraint
    {
        public class Class<T>
            where T : struct
        {
        }
    }
}
