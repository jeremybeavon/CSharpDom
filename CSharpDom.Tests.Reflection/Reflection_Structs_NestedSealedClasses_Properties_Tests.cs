using CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverridePropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivatePropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverridePropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticProperty));
        }
    }
}
