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
            TestClassAsync(typeof(ClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithVolatileField));
        }
    }
}
