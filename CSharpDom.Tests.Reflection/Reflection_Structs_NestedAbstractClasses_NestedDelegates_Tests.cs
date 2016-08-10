using CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalNestedDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateNestedDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedNestedDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalNestedDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicNestedDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicNestedDelegate));
        }
    }
}
