using CSharpDom.TestTarget.Structs.NestedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWithBaseClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalNestedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateNestedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedNestedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalNestedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicNestedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicNestedClass));
        }
    }
}
