using CSharpDom.TestTarget.Classes.NestedClasses.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceMethodWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceMethodWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceMethodWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceWithMethodWithParametersWithAttributesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
