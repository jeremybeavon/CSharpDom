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
            TestClassAsync(typeof(ClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithVolatileField));
        }
    }
}
