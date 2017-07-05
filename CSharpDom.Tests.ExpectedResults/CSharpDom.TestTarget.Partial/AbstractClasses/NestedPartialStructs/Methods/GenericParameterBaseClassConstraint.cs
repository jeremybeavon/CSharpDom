namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Methods
{
    public abstract class AbstractClassWithNestedStructWithMethodWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
