namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedClasses
{
    public partial class PartialClassWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
