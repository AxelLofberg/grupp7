namespace PersonalVerification
{
    public static class PersonalInfoValidator
    {
        public static bool Validate(string personalNumber)
        {
            // Check if the personal number has the correct length.
            if (personalNumber.Length != 10 && personalNumber.Length != 11 && personalNumber.Length != 12)
            {
                return false;
            }

            // Check if all characters are digits (except possible hyphen or plus sign).
            foreach (char c in personalNumber)
            {
                if (!char.IsDigit(c) && c != '-' && c != '+')
                {
                    return false;
                }
            }

            // If the personal number is in the format "YYMMDDXXXX" or "YYMMDD-XXXX"
            if (personalNumber.Length == 10 || personalNumber.Length == 12)
            {
                int year = int.Parse(personalNumber.Substring(0, 2));
                int month = int.Parse(personalNumber.Substring(2, 2));
                int day = int.Parse(personalNumber.Substring(4, 2));

                // A simple check for year, month, and day.
                if (year < 0 || month < 1 || month > 12 || day < 1 || day > 31)
                {
                    return false;
                }
            }

            // Additional checks for personal numbers can be added here.

            return true;
        }
    }
}