using CSharpDom.TestTarget.Structs.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicAutoProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideAutoProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithVirtualAutoProperty));
        }
    }
}
