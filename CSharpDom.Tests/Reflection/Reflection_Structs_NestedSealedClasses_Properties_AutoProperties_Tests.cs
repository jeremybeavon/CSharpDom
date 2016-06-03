using CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOverrideAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
