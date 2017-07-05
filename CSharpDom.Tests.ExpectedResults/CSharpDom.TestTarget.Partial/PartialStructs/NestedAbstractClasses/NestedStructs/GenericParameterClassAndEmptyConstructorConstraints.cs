namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
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
