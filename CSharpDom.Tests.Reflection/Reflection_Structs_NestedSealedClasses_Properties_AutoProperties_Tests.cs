using CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
