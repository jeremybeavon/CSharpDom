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
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
