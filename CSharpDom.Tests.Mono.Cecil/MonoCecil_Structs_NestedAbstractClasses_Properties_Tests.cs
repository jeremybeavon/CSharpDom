using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverridePropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivatePropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
