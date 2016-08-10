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
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticVolatileFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithVolatileFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithVolatileField));
        }
    }
}
