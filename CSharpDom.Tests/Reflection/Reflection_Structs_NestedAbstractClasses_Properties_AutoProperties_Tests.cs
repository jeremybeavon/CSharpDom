using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewVirtualAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOverrideAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVirtualAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
