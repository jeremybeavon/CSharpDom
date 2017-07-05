namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
