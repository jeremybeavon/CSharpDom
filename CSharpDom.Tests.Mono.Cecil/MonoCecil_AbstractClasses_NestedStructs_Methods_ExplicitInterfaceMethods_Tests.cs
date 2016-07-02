using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceMethodWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
