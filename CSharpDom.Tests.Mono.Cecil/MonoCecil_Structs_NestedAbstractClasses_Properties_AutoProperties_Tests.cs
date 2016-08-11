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
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicAutoProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideAutoProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
