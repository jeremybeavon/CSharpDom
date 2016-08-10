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
            TestStructAsync(typeof(StructWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualAutoProperty));
        }
    }
}
