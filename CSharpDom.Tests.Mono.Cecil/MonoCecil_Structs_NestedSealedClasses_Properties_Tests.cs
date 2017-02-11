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
            TestStruct(typeof(StructWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverridePropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticProperty));
        }
    }
}
