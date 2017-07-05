namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
