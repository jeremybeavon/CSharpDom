namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedClasses
{
    public partial class PartialClassWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
