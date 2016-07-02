using CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitInterfaceMethodWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitInterfaceWithMethodWithParametersWithAttributesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
