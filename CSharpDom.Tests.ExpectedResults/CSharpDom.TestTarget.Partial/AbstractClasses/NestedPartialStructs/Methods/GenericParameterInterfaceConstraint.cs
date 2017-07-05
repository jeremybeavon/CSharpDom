namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Methods
{
    public abstract class AbstractClassWithNestedStructWithMethodWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
