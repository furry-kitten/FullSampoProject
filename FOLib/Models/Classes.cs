﻿namespace FO.Models
{
    public class Classes : DBClass
    {
        private Dancer dancer;
        private SHAClasses shaClasses;
        private byte points;

        public Classes()
        {
            //Name = $"{shaClasses.Name}{points}";
        }
        public Classes(Dancer dancer, SHAClasses classes, byte points = 0)
        {
            this.dancer = dancer;
            this.SHAClasses = classes;
            this.points = points;
        }

        public Dancer Dancer
        {
            get => dancer;
            set { dancer = value; OnPropertyChanged(); }
        }
        public SHAClasses SHAClasses
        {
            get => shaClasses;
            set { shaClasses = value; OnPropertyChanged(); }
        }
        public byte Points
        {
            get => points;
            set { points = value; OnPropertyChanged(); }
        }

        public override string ToString() =>
            $"{shaClasses.Name} {points}";
    }
}
