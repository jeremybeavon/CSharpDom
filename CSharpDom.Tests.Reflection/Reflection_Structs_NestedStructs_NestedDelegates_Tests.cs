using CSharpDom.TestTarget.Structs.NestedStructs.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithNestedDelegateWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalNestedDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateNestedDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicNestedDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicNestedDelegate));
        }
    }
}
