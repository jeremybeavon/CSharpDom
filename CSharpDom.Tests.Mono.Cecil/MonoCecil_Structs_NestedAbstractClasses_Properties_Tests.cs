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
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverridePropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivatePropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
