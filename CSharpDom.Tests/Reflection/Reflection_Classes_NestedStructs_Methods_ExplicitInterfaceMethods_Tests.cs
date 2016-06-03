using CSharpDom.TestTarget.Classes.NestedStructs.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceWithMethodWithParametersWithAttributesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
