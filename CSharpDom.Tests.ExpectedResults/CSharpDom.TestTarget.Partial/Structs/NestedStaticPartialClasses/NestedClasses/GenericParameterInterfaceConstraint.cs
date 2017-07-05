namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
