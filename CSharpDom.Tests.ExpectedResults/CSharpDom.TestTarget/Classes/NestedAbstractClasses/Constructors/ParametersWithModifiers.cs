namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Constructors
{
    public class ClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers
    {
        public abstract class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
