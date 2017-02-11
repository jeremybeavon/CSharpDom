using CSharpDom.TestTarget.Structs.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithInternalAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithVirtualAutoProperty));
        }
    }
}
