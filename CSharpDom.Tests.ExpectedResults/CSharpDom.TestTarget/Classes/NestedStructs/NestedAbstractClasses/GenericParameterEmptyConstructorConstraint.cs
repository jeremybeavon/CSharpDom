namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedAbstractClasses
{
    public class ClassWithNestedStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
