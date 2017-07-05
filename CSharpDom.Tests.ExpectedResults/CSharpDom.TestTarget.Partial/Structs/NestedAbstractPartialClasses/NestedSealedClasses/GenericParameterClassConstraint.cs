namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
