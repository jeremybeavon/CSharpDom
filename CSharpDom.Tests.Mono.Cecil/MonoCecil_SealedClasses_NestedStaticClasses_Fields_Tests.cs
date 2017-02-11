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
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithVolatileField));
        }
    }
}
