using CSharpDom.TestTarget.Structs.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverrideAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualAutoProperty));
        }
    }
}
