namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
