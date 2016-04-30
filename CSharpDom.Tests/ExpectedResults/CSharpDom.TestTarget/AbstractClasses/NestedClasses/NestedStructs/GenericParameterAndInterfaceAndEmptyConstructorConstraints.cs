namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
