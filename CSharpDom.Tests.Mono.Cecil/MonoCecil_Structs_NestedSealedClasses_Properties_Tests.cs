using CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverridePropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticProperty));
        }
    }
}
