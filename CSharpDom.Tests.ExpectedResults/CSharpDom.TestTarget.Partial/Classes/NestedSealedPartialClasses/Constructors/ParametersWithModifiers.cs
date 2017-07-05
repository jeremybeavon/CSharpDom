namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Constructors
{
    public class ClassWithNestedSealedPartialClassWithConstructorWithParametersWithModifiers
    {
        public sealed partial class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
