namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
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
