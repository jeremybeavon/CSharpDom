using CSharpDom.TestTarget.Structs.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedDelegateWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithInternalNestedDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithPublicNestedDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithPublicNestedDelegate));
        }
    }
}
