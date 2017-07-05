namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class<T>
            where T : BaseClass
        {
        }
    }
}
