using System;

namespace SmartStore.Data.Setup
{

    public class SeedDataException : Exception
    {
        public SeedDataException(string stage, Exception inner)
            : base("An error occurred during installation. Stage: " + stage, inner)
        {
            this.Stage = stage;
        }

        public string Stage { get; set; }

    }

}
