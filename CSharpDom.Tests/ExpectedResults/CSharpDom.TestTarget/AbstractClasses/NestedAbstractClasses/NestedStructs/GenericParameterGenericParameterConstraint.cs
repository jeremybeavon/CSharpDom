namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraint
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
