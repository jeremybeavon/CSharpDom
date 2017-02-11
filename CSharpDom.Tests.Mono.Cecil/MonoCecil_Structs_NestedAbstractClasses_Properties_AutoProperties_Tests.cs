using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicAutoProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideAutoProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
