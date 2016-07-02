using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedSealedClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithInternalNestedEnumUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPrivateNestedEnumUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedNestedEnumUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPublicNestedEnumUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicNestedEnum));
        }
    }
}
