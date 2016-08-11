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
            TestStructAsync(typeof(StructWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithOverridePropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithStaticPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualProperty));
        }
    }
}
