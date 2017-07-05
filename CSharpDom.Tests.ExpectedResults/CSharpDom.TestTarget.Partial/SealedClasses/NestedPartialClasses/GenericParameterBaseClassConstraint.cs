namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public class Class<T>
            where T : BaseClass
        {
        }
    }
}
