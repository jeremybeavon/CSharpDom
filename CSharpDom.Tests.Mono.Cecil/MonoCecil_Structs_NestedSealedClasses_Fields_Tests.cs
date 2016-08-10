using CSharpDom.TestTarget.Structs.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithVolatileField));
        }
    }
}
