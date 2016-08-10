using CSharpDom.TestTarget.Structs.NestedSealedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticMethodUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticMethod));
        }
    }
}
