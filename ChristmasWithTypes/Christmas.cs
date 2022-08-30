using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public string TreeHeight { get; set; } //TODO Make the Height property nullable

        //TODO Make the property, "Day", type enum
        public enum Day {"sunday", "monday", "tuesday", "wednesday", "thursday", "Friday", "Saturday"};

    }
}
