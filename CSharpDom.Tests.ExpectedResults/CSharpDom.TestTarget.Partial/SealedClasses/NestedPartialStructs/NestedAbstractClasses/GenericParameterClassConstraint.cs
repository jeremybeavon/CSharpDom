namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedStructWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
