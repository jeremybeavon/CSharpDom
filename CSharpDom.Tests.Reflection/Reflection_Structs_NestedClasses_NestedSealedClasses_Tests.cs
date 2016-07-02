using CSharpDom.TestTarget.Structs.NestedClasses.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_NestedSealedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWithBaseClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedSealedClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalNestedSealedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateNestedSealedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedNestedSealedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalNestedSealedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicNestedSealedClassUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicNestedSealedClass));
        }
    }
}
