namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
