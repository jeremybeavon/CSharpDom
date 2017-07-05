namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraint
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
