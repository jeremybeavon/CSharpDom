namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
