namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
