using CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStaticClasses_NestedDelegates_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedDelegateWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedDelegateWith1GenericParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedDelegateWith2GenericParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedDelegateWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalNestedDelegateUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithAttributesUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithModifiersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateNestedDelegateUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedNestedDelegateUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedInternalNestedDelegateUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicNestedDelegateUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicNestedDelegate));
        }
    }
}
