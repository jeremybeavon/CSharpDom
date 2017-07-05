namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
