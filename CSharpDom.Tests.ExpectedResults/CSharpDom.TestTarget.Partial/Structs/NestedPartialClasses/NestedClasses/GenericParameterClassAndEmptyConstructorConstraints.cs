namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedClasses
{
    public struct StructWithNestedPartialClassWithNestedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
