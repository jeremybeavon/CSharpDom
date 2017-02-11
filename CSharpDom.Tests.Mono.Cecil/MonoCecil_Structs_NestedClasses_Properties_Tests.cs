using CSharpDom.TestTarget.Structs.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithInternalPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithOverridePropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithStaticPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithVirtualProperty));
        }
    }
}
