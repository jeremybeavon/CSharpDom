namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
