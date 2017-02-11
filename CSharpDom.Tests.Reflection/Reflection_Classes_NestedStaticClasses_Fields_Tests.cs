using CSharpDom.TestTarget.Classes.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStaticClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithConstFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithVolatileField));
        }
    }
}
