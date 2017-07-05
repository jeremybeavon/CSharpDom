namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedAbstractClassWithGenericParameterBaseClassConstraint
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
