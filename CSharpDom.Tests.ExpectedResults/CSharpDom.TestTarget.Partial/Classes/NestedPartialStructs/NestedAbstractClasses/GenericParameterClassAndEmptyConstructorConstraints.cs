namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedAbstractClasses
{
    public class ClassWithNestedStructWithNestedAbstractPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
