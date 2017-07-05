namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
