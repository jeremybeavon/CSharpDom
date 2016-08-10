using CSharpDom.TestTarget.Structs.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithInternalPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverridePropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivatePropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualProperty));
        }
    }
}
