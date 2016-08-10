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
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
