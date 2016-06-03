using CSharpDom.TestTarget.Structs.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverridePropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivatePropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualProperty));
        }
    }
}
