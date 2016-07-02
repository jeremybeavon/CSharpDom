namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedAbstractClasses
{
    public class ClassWithNestedStructWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
