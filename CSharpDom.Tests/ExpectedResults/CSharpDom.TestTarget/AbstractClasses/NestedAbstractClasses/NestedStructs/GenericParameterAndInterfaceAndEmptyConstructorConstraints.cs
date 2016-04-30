namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
