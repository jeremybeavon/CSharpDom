namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
