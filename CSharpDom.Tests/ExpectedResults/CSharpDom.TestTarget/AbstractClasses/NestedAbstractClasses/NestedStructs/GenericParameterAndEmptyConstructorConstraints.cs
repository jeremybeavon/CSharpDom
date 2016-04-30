namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
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
