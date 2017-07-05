namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
