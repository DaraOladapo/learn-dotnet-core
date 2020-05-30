namespace Lesson_21_Structures
{
    struct StructShape {
        public double Perimeter {
            get;
            set;
        }

        public double Area {
            get;
            set;
        }

        public StructShape(double _Perimeter, double _Area) {
            Perimeter=_Perimeter;
            Area=_Area;
        }
    }
}