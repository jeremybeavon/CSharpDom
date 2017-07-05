namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
