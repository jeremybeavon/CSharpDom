namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
