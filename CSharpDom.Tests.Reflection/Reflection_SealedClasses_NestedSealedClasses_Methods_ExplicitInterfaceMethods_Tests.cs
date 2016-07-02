using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedSealedClasses_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameterUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceWithMethodWithParametersWithAttributesUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
