using CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOverridePropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivatePropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithSealedOverridePropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticProperty));
        }
    }
}
