namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
