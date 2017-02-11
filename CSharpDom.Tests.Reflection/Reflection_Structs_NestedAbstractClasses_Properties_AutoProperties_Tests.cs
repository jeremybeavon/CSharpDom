using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
