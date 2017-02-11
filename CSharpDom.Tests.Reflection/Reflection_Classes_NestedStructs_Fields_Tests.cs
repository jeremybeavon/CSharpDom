using CSharpDom.TestTarget.Classes.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithConstFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithVolatileField));
        }
    }
}
