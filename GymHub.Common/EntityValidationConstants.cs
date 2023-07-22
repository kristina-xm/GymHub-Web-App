namespace GymHub.Common
{
    
    public static class EntityValidationConstants
    {
        public static class User
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 25;

            public const int NumberMaxLength = 20;
            public const int NumberMinLength = 10;

            public const int PasswordMaxLength = 100;
            public const int PasswordMinLength = 6;
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
            public const int BioMinLength = 10;


            public const int ExperienceMax = 30;
            public const int ExperienceMin = 0;
        }

        public static class Certification
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 3;
        }

        public static class IndividualTraining
        {
            public const int IntensityMaxLength = 30;
        }

        public static class Trainee
        {
            public const int LevelMaxLength = 20;

            public const int AgeMax = 60;
            public const int AgeMin = 16;

            public const double WeightMin = 30.00; 
            public const double WeightMax = 200.00;

            public const double HeightMin = 1.40;
            public const double HeightMax = 3.00;
        }
    }
}
