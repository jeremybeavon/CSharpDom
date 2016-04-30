namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedClassWithNestedStructWithGenericParameterStructConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
