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
            TestStructAsync(typeof(StructWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicAutoProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideAutoProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualAutoProperty));
        }
    }
}
