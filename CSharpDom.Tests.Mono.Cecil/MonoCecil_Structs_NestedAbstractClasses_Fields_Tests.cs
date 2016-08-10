using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVolatileField));
        }
    }
}
