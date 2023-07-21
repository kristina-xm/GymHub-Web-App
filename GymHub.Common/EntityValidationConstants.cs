namespace GymHub.Common
{
    
    public static class EntityValidationConstants
    {
        public static class User
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 25;
        }

        public static class GroupActivity
        {
            public const int NameMaxLength = 15;
        }

        public static class Trainer
        {
            public const int BioMaxLength = 150;
        }
    }
}
