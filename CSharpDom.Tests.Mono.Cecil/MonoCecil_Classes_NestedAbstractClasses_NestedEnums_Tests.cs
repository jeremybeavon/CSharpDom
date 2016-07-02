using CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicNestedEnumUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicNestedEnum));
        }
    }
}
