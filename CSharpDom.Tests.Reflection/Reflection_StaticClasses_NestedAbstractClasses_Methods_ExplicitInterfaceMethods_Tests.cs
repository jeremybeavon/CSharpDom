using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1GenericParameterUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2GenericParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExplicitInterfaceWithMethodWithParametersWithAttributesUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExplicitInterfaceWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
