namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses
{
    public class ClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public abstract class Class<T>
            where T : struct
        {
        }
    }
}
