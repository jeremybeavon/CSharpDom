using CSharpDom.TestTarget.Structs.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithConstFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVolatileField));
        }
    }
}
