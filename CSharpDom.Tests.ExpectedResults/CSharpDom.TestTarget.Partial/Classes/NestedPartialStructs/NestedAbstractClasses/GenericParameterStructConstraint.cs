namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedAbstractClasses
{
    public class ClassWithNestedStructWithNestedAbstractPartialClassWithGenericParameterStructConstraint
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
