namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Methods
{
    public abstract class AbstractClassWithNestedStructWithMethodWith1GenericParameter
    {
        public struct Struct
        {
            public T Method<T>()
            {
                return default(T);
            }
        }
    }
}
