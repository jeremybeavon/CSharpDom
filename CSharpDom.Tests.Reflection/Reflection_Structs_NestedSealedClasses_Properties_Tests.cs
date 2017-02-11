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
            TestStruct(typeof(StructWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverridePropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivatePropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverridePropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticProperty));
        }
    }
}
