namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedAbstractPartialClassWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
