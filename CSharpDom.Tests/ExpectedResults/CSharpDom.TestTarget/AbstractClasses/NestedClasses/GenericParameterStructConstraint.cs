namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedClassWithGenericParameterStructConstraint
    {
        public class Class<T>
            where T : struct
        {
        }
    }
}
