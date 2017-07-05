namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedClasses
{
    public partial class PartialClassWithNestedStructWithNestedClassWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
