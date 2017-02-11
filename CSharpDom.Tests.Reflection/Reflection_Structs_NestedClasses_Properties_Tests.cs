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
            TestStruct(typeof(StructWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverridePropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivatePropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithVirtualProperty));
        }
    }
}
