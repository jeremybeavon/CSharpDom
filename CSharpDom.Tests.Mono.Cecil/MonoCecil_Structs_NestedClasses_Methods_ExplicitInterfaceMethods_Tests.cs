using CSharpDom.TestTarget.Structs.NestedClasses.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceMethodWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
