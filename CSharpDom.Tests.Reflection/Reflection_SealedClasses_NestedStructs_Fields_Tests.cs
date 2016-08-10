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
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithReadOnlyFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithVolatileField));
        }
    }
}
