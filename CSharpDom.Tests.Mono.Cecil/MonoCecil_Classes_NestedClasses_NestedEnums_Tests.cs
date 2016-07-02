using CSharpDom.TestTarget.Classes.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedEnum));
        }
    }
}
