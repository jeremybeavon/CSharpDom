namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedAbstractClasses
{
    public class ClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
