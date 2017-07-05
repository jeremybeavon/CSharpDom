namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
