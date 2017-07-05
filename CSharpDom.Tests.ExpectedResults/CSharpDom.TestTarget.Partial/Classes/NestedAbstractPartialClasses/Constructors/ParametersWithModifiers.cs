namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Constructors
{
    public class ClassWithNestedAbstractPartialClassWithConstructorWithParametersWithModifiers
    {
        public abstract partial class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
