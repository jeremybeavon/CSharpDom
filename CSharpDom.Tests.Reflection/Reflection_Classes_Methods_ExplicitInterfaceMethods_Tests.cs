using CSharpDom.TestTarget.Classes.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithExplicitInterfaceMethodWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithExplicitInterfaceMethodWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithExplicitInterfaceMethodWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassExplicitInterfaceWithMethodWithParametersWithAttributesUsingReflection()
        {
            await TestClassAsync(typeof(ClassExplicitInterfaceWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
