using Xunit;

namespace PersonalVerification.Tests
{
    public class PersonalInfoValidatorTests
    {
        [Fact]
        public void Validate_ValidPersonalNumber_ReturnsTrue()
        {
            // Given
            string personalNumber = "8808214855";

            // When
            bool result = PersonalInfoValidator.Validate(personalNumber);

            // Then
            Assert.True(result);
        }

        [Fact]
        public void Validate_InvalidPersonalNumber_ReturnsFalse()
        {
            // Given
            string personalNumber = "9003994855";

            // When
            bool result = PersonalInfoValidator.Validate(personalNumber);

            // Then
            Assert.False(result);
        }
    }
}