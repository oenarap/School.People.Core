using System;

namespace School.People.Core
{
    public static class Constants
    {
        public const int ContactNumbersMaxLength = 16;
        public const int EmailAddressMaxLength = 64;
        public const int IdNumbersMaxLength = 16;
        public const int BloodTypeMaxLength = 8;
        public const int CitizenshipMaxLength = 64;
        public const int DualCitizenshipModeMaxLength = 24;
        public const int CivilStatusMaxLength = 24;
        public const int SexMaxLength = 16;
        public const int ScholarshipOrHonorsReceivedMaxLength = 32;
        public const int HighestLevelOrUnitsEarnedMaxLength = 32;
        public const int DegreeCourseMaxLength = 64;
        public const int SchoolNameMaxLength = 64;
        public const int EducationLevelMaxLength = 64;

        public const int PersonNameFieldsMinLength = 2;
        public const int PersonSurnameMaxLength = 32;
        public const int PersonFirstNameMaxLength = 64;
        public const int PersonNameExtensionMaxLength = 16;
        public const int PersonTitleMaxLength = 16;

        public const string ContactDetailsTableName = "ContactDetailsTable";
        public const string PersonalInformationTableName = "PersonalInformationTable";
        public const string PeopleTableName = "PeopleTable";
        public const string DateOfBirthTableName = "DateOfBirthTable";
        public const string EducationTableName = "EducationTable";
    }
}
