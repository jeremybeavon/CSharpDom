using CSharpDom.TestTarget.SealedClasses.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithVolatileField));
        }
    }
}
