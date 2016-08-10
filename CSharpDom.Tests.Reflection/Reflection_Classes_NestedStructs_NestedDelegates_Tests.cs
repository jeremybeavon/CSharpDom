using CSharpDom.TestTarget.Classes.NestedStructs.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalNestedDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateNestedDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicNestedDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicNestedDelegate));
        }
    }
}
