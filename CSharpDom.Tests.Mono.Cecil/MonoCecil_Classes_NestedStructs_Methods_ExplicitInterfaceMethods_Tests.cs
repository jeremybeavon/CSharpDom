using CSharpDom.TestTarget.Classes.NestedStructs.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
