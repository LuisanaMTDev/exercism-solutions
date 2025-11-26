public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
      if (phoneNumber == null) {
        return (false, true, "");
      }
      string[] splitedString = phoneNumber.Split("-", count: 3);
      (string first, string second, string third) phoneNumberParts = (splitedString[0], splitedString[1], splitedString[2]);

      return (phoneNumberParts.first == "212", phoneNumberParts.second == "555", phoneNumberParts.third);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
