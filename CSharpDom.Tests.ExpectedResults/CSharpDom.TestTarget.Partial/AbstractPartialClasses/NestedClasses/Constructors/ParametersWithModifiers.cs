namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Constructors
{
    public abstract partial class AbstractPartialClassWithNestedClassWithConstructorWithParametersWithModifiers
    {
        public class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
