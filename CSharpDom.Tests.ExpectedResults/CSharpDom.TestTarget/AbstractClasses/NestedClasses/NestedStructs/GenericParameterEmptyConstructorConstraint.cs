namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
