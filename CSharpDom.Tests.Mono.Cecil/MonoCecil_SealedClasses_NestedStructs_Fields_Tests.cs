using CSharpDom.TestTarget.SealedClasses.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithVolatileField));
        }
    }
}
