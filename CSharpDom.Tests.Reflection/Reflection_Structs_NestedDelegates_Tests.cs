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
            TestStruct(typeof(StructWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            TestStruct(typeof(StructWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithInternalNestedDelegateUsingReflection()
        {
            TestStruct(typeof(StructWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedDelegateUsingReflection()
        {
            TestStruct(typeof(StructWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithPublicNestedDelegateUsingReflection()
        {
            TestStruct(typeof(StructWithPublicNestedDelegate));
        }
    }
}
