namespace GymHub.Common
{
    
    public static class EntityValidationConstants
    {
        public static class User
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 25;

            public const int NumberMaxLength = 20;
        }

        public static class GroupActivity
        {
            public const int NameMaxLength = 20;
            public const int DescriptionMaxLength = 200;
        }

        public static class ActivityCategory
        {
            public const int IntensityMaxLength = 30;
            public const int TraineeLevelMaxLenght = 40;
        }

        public static class Trainer
        {
            public const int BioMaxLength = 150;
        }

        public static class Certification
        {
            public const int NameMaxLength = 50;
        }

        public static class IndividualTraining
        {
            public const int IntensityMaxLength = 30;
        }

        public static class Trainee
        {
            public const int LevelMaxLength = 20;
        }
    }
}
