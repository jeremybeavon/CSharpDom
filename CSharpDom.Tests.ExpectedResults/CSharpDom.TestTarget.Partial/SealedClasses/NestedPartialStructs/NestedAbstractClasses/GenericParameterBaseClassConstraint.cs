namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedStructWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
