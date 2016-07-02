using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedAbstractClasses_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1AttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExplicitInterfaceWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExplicitInterfaceWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
