using CSharpDom.TestTarget.Classes.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithPrivateNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithProtectedNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithInternalNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithPublicNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPublicNestedEnum));
        }
    }
}
