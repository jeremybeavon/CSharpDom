namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedStructs
{
    public struct StructWithNestedAbstractPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
