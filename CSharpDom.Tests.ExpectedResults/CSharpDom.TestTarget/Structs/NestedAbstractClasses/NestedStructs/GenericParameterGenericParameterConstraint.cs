namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedStructs
{
    public struct StructWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
