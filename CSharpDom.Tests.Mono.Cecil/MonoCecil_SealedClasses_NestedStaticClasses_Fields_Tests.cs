using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithConstFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithVolatileField));
        }
    }
}
