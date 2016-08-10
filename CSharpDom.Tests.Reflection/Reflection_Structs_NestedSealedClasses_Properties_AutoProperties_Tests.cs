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
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
