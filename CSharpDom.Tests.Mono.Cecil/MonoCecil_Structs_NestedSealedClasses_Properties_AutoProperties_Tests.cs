using CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
