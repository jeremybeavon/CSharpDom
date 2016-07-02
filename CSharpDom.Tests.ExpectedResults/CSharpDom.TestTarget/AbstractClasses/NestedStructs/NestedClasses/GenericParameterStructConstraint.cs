namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedClassWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
